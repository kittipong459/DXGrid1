namespace DXGrid1
{
    partial class wMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ogdData = new DevExpress.XtraGrid.GridControl();
            this.ogdDataList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ockColCheckBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otbColText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogdData
            // 
            this.ogdData.Location = new System.Drawing.Point(70, 100);
            this.ogdData.MainView = this.ogdDataList;
            this.ogdData.Name = "ogdData";
            this.ogdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.ogdData.Size = new System.Drawing.Size(814, 444);
            this.ogdData.TabIndex = 0;
            this.ogdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ogdDataList});
            // 
            // ogdDataList
            // 
            this.ogdDataList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ockColCheckBox,
            this.otbColText});
            this.ogdDataList.GridControl = this.ogdData;
            this.ogdDataList.Name = "ogdDataList";
            // 
            // ockColCheckBox
            // 
            this.ockColCheckBox.Caption = "เลือก";
            this.ockColCheckBox.ColumnEdit = this.repositoryItemCheckEdit1;
            this.ockColCheckBox.Name = "ockColCheckBox";
            this.ockColCheckBox.Visible = true;
            this.ockColCheckBox.VisibleIndex = 0;
            // 
            // otbColText
            // 
            this.otbColText.Caption = "ข้อมูล";
            this.otbColText.FieldName = "tDataText";
            this.otbColText.Name = "otbColText";
            this.otbColText.Visible = true;
            this.otbColText.VisibleIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 570);
            this.Controls.Add(this.ogdData);
            this.Name = "wMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ogdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ogdData;
        private DevExpress.XtraGrid.Views.Grid.GridView ogdDataList;
        private DevExpress.XtraGrid.Columns.GridColumn ockColCheckBox;
        private DevExpress.XtraGrid.Columns.GridColumn otbColText;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}

