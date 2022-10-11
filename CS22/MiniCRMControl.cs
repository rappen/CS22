using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XTB.Helpers.Extensions;
using System;
using System.Data;
using System.Linq;
using XrmToolBox.Extensibility;

namespace CS22
{
    public partial class MiniCRMControl : PluginControlBase
    {
        public MiniCRMControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_ConnectionUpdated(object sender, ConnectionUpdatedEventArgs e)
        {
            xrmView.Service = e.Service;
            xrmData.Service = e.Service;
            xrmRecordHost1.Service = e.Service;
            GetTables();
        }

        private void GetTables()
        {
            Enabled = false;
            this.GetAllEntityMetadatas((em) =>
            {
                xrmTable.DataSource = em
                    .Where(e => e.IsManaged == false | chkManaged.Checked);
                Enabled = true;
            });
        }

        private void chkManaged_CheckedChanged(object sender, EventArgs e)
        {
            GetTables();
        }

        private void xrmTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetViews();
        }

        private void GetViews()
        {
            var entity = xrmTable.SelectedEntity;
            xrmPrimaryColumn.Column = entity?.PrimaryNameAttribute;

            if (entity == null)
            {
                return;
            }

            var query = new QueryExpression("savedquery");
            query.ColumnSet.AddColumns("name", "fetchxml", "layoutxml");
            query.Criteria.AddCondition("statecode", ConditionOperator.Equal, 0);
            query.Criteria.AddCondition("fetchxml", ConditionOperator.NotNull);
            query.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, entity.LogicalName);

            Enabled = false;
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Views...",
                Work = (_, args) =>
                {
                    args.Result = Service.RetrieveMultiple(query);
                },
                PostWorkCallBack = (args) =>
                {
                    Enabled = true;
                    ShowErrorDialog(args.Error);
                    if (args.Error == null && args.Result is EntityCollection views)
                    {
                        xrmView.DataSource = views;
                    }
                }
            });
        }

        private void xrmView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            var fetch = xrmView.SelectedRecord?.GetAttributeValue<string>("fetchxml");
            var layout = xrmView.SelectedRecord?.GetAttributeValue<string>("layoutxml");
            if (string.IsNullOrEmpty(fetch))
            {
                return;
            }
            Enabled = false;
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Data...",
                Work = (_, args) =>
                {
                    xrmData.SetDataSource(fetch, layout);
                    //          args.Result = Service.RetrieveMultiple(new FetchExpression(fetch));
                },
                PostWorkCallBack = (args) =>
                {
                    Enabled = true;
                    ShowErrorDialog(args.Error);
                    //if (args.Error == null && args.Result is EntityCollection data)
                    //{
                    //    xrmData.DataSource = data;
                    //}
                }
            });
        }

        private void xrmData_RecordEnter(object sender, Rappen.XTB.Helpers.Controls.XRMRecordEventArgs e)
        {
            xrmRecordHost1.Record = e.Entity;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Enabled = false;
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Saving!",
                Work = (_, a) =>
                {
                    a.Result = xrmRecordHost1.SaveChanges();
                },
                PostWorkCallBack = (a) =>
                {
                    Enabled = true;
                    ShowErrorDialog(a.Error);
                    if (a.Error == null && a.Result is bool result)
                    {
                        GetData();
                    }
                }
            });
        }
    }
}