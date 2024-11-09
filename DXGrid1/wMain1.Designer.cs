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
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.otbColText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otbColDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otbColNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.otbColDecimal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.olaShoTxt = new System.Windows.Forms.Label();
            this.oilPdt = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.ogdData.Click += new System.EventHandler(this.ogdData_Click);
            // 
            // ogdDataList
            // 
            this.ogdDataList.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.ogdDataList.AppearancePrint.EvenRow.Options.UseFont = true;
            this.ogdDataList.ColumnPanelRowHeight = 50;
            this.ogdDataList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ockColCheckBox,
            this.otbColText,
            this.otbColDateTime,
            this.otbColNumber,
            this.otbColDecimal,
            this.oilPdt});
            this.ogdDataList.GridControl = this.ogdData;
            this.ogdDataList.Name = "ogdDataList";
            this.ogdDataList.OptionsPrint.EnableAppearanceEvenRow = true;
            this.ogdDataList.RowHeight = 45;
            // 
            // ockColCheckBox
            // 
            this.ockColCheckBox.Caption = "เลือก";
            this.ockColCheckBox.ColumnEdit = this.repositoryItemCheckEdit1;
            this.ockColCheckBox.Name = "ockColCheckBox";
            this.ockColCheckBox.Visible = true;
            this.ockColCheckBox.VisibleIndex = 0;
            this.ockColCheckBox.Width = 41;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // otbColText
            // 
            this.otbColText.Caption = "ข้อมูล";
            this.otbColText.FieldName = "tDataText";
            this.otbColText.Name = "otbColText";
            this.otbColText.Visible = true;
            this.otbColText.VisibleIndex = 1;
            this.otbColText.Width = 278;
            // 
            // otbColDateTime
            // 
            this.otbColDateTime.Caption = "วันเวลา";
            this.otbColDateTime.FieldName = "dDataDateTime";
            this.otbColDateTime.Name = "otbColDateTime";
            this.otbColDateTime.Visible = true;
            this.otbColDateTime.VisibleIndex = 2;
            this.otbColDateTime.Width = 133;
            // 
            // otbColNumber
            // 
            this.otbColNumber.Caption = "ตัวเลข";
            this.otbColNumber.FieldName = "nDataNumber";
            this.otbColNumber.Name = "otbColNumber";
            this.otbColNumber.Visible = true;
            this.otbColNumber.VisibleIndex = 3;
            this.otbColNumber.Width = 107;
            // 
            // otbColDecimal
            // 
            this.otbColDecimal.Caption = "ตัวเลขทศนิยม";
            this.otbColDecimal.FieldName = "cDataDecimal";
            this.otbColDecimal.Name = "otbColDecimal";
            this.otbColDecimal.Visible = true;
            this.otbColDecimal.VisibleIndex = 4;
            this.otbColDecimal.Width = 126;
            // 
            // olaShoTxt
            // 
            this.olaShoTxt.AutoSize = true;
            this.olaShoTxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaShoTxt.Location = new System.Drawing.Point(70, 28);
            this.olaShoTxt.Name = "olaShoTxt";
            this.olaShoTxt.Size = new System.Drawing.Size(67, 25);
            this.olaShoTxt.TabIndex = 1;
            this.olaShoTxt.Text = "label1";
            // 
            // oilPdt
            // 
            this.oilPdt.Caption = "img";
            this.oilPdt.Name = "oilPdt";
            this.oilPdt.Visible = true;
            this.oilPdt.VisibleIndex = 5;
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 570);
            this.Controls.Add(this.olaShoTxt);
            this.Controls.Add(this.ogdData);
            this.Name = "wMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ogdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ogdData;
        private DevExpress.XtraGrid.Views.Grid.GridView ogdDataList;
        private DevExpress.XtraGrid.Columns.GridColumn ockColCheckBox;
        private DevExpress.XtraGrid.Columns.GridColumn otbColText;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn otbColDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn otbColNumber;
        private DevExpress.XtraGrid.Columns.GridColumn otbColDecimal;
        private System.Windows.Forms.Label olaShoTxt;
        private DevExpress.XtraGrid.Columns.GridColumn oilPdt;
    }
}

