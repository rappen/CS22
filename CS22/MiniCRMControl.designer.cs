namespace CS22
{
    partial class MiniCRMControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkManaged = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new System.Windows.Forms.Button();
            this.xrmCreatedColumn = new Rappen.XTB.Helpers.Controls.XRMColumnDateTime();
            this.xrmRecordHost1 = new Rappen.XTB.Helpers.Controls.XRMRecordHost();
            this.xrmPrimaryColumn = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.xrmData = new Rappen.XTB.Helpers.Controls.XRMDataGridView();
            this.xrmView = new Rappen.XTB.Helpers.Controls.XRMColumnLookup();
            this.xrmTable = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xrmData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xrmView);
            this.panel1.Controls.Add(this.chkManaged);
            this.panel1.Controls.Add(this.xrmTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 100);
            this.panel1.TabIndex = 0;
            // 
            // chkManaged
            // 
            this.chkManaged.AutoSize = true;
            this.chkManaged.Location = new System.Drawing.Point(27, 6);
            this.chkManaged.Name = "chkManaged";
            this.chkManaged.Size = new System.Drawing.Size(171, 36);
            this.chkManaged.TabIndex = 1;
            this.chkManaged.Text = "Managed";
            this.chkManaged.UseVisualStyleBackColor = true;
            this.chkManaged.CheckedChanged += new System.EventHandler(this.chkManaged_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xrmCreatedColumn);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.xrmPrimaryColumn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xrmData);
            this.splitContainer1.Size = new System.Drawing.Size(1492, 616);
            this.splitContainer1.SplitterDistance = 497;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(346, 96);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xrmCreatedColumn
            // 
            this.xrmCreatedColumn.Column = "createdon";
            this.xrmCreatedColumn.CustomFormat = "yyyy-MM-dd HH:mm";
            this.xrmCreatedColumn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.xrmCreatedColumn.Location = new System.Drawing.Point(27, 153);
            this.xrmCreatedColumn.Name = "xrmCreatedColumn";
            this.xrmCreatedColumn.RecordHost = this.xrmRecordHost1;
            this.xrmCreatedColumn.Size = new System.Drawing.Size(412, 38);
            this.xrmCreatedColumn.TabIndex = 2;
            // 
            // xrmRecordHost1
            // 
            this.xrmRecordHost1.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.xrmRecordHost1.LogicalName = null;
            this.xrmRecordHost1.Record = null;
            this.xrmRecordHost1.Service = null;
            // 
            // xrmPrimaryColumn
            // 
            this.xrmPrimaryColumn.Column = null;
            this.xrmPrimaryColumn.DisplayFormat = "";
            this.xrmPrimaryColumn.Location = new System.Drawing.Point(23, 77);
            this.xrmPrimaryColumn.Name = "xrmPrimaryColumn";
            this.xrmPrimaryColumn.RecordHost = this.xrmRecordHost1;
            this.xrmPrimaryColumn.Size = new System.Drawing.Size(449, 38);
            this.xrmPrimaryColumn.TabIndex = 0;
            // 
            // xrmData
            // 
            this.xrmData.AllowUserToAddRows = false;
            this.xrmData.AllowUserToDeleteRows = false;
            this.xrmData.AllowUserToOrderColumns = true;
            this.xrmData.AllowUserToResizeRows = false;
            this.xrmData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xrmData.ColumnOrder = "";
            this.xrmData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xrmData.FilterColumns = "";
            this.xrmData.LayoutXML = null;
            this.xrmData.Location = new System.Drawing.Point(0, 0);
            this.xrmData.Name = "xrmData";
            this.xrmData.ReadOnly = true;
            this.xrmData.RowHeadersWidth = 102;
            this.xrmData.RowTemplate.Height = 40;
            this.xrmData.Service = null;
            this.xrmData.ShowFriendlyNames = true;
            this.xrmData.ShowIdColumn = false;
            this.xrmData.ShowIndexColumn = false;
            this.xrmData.ShowLocalTimes = true;
            this.xrmData.Size = new System.Drawing.Size(991, 616);
            this.xrmData.TabIndex = 0;
            this.xrmData.RecordEnter += new Rappen.XTB.Helpers.Controls.XRMRecordEventHandler(this.xrmData_RecordEnter);
            // 
            // xrmView
            // 
            this.xrmView.AddNullRecord = true;
            this.xrmView.Column = null;
            this.xrmView.DisplayFormat = "";
            this.xrmView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmView.Filter = null;
            this.xrmView.FormattingEnabled = true;
            this.xrmView.Location = new System.Drawing.Point(589, 50);
            this.xrmView.Name = "xrmView";
            this.xrmView.RecordHost = null;
            this.xrmView.Service = null;
            this.xrmView.Size = new System.Drawing.Size(495, 39);
            this.xrmView.TabIndex = 2;
            this.xrmView.SelectedIndexChanged += new System.EventHandler(this.xrmView_SelectedIndexChanged);
            // 
            // xrmTable
            // 
            this.xrmTable.AddNullOption = true;
            this.xrmTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmTable.FormattingEnabled = true;
            this.xrmTable.Location = new System.Drawing.Point(25, 50);
            this.xrmTable.Name = "xrmTable";
            this.xrmTable.Size = new System.Drawing.Size(524, 39);
            this.xrmTable.TabIndex = 0;
            this.xrmTable.SelectedIndexChanged += new System.EventHandler(this.xrmTable_SelectedIndexChanged);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1492, 716);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.MyPluginControl_ConnectionUpdated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xrmData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox xrmTable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkManaged;
        private Rappen.XTB.Helpers.Controls.XRMColumnLookup xrmView;
        private Rappen.XTB.Helpers.Controls.XRMDataGridView xrmData;
        private Rappen.XTB.Helpers.Controls.XRMRecordHost xrmRecordHost1;
        private Rappen.XTB.Helpers.Controls.XRMColumnText xrmPrimaryColumn;
        private System.Windows.Forms.Button btnSave;
        private Rappen.XTB.Helpers.Controls.XRMColumnDateTime xrmCreatedColumn;
    }
}
