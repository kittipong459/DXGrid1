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
            this.otbColPdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.olaShoTxt = new System.Windows.Forms.Label();
            this.olaDate = new System.Windows.Forms.Label();
            this.olaQty = new System.Windows.Forms.Label();
            this.otbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opbShowIMG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ogdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbShowIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // ogdData
            // 
            this.ogdData.Location = new System.Drawing.Point(50, 186);
            this.ogdData.MainView = this.ogdDataList;
            this.ogdData.Name = "ogdData";
            this.ogdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemPictureEdit1});
            this.ogdData.Size = new System.Drawing.Size(834, 358);
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
            this.otbColPdt});
            this.ogdDataList.GridControl = this.ogdData;
            this.ogdDataList.Name = "ogdDataList";
            this.ogdDataList.RowHeight = 45;
            // 
            // ockColCheckBox
            // 
            this.ockColCheckBox.Caption = "เลือก";
            this.ockColCheckBox.ColumnEdit = this.repositoryItemCheckEdit1;
            this.ockColCheckBox.Name = "ockColCheckBox";
            this.ockColCheckBox.OptionsColumn.AllowEdit = false;
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
            this.otbColText.OptionsColumn.AllowEdit = false;
            this.otbColText.Visible = true;
            this.otbColText.VisibleIndex = 1;
            this.otbColText.Width = 278;
            // 
            // otbColDateTime
            // 
            this.otbColDateTime.Caption = "วันเวลา";
            this.otbColDateTime.FieldName = "dDataDateTime";
            this.otbColDateTime.Name = "otbColDateTime";
            this.otbColDateTime.OptionsColumn.AllowEdit = false;
            this.otbColDateTime.Visible = true;
            this.otbColDateTime.VisibleIndex = 2;
            this.otbColDateTime.Width = 133;
            // 
            // otbColNumber
            // 
            this.otbColNumber.Caption = "ตัวเลข";
            this.otbColNumber.FieldName = "nDataNumber";
            this.otbColNumber.Name = "otbColNumber";
            this.otbColNumber.OptionsColumn.AllowEdit = false;
            this.otbColNumber.Visible = true;
            this.otbColNumber.VisibleIndex = 3;
            this.otbColNumber.Width = 107;
            // 
            // otbColDecimal
            // 
            this.otbColDecimal.Caption = "ตัวเลขทศนิยม";
            this.otbColDecimal.FieldName = "cDataDecimal";
            this.otbColDecimal.Name = "otbColDecimal";
            this.otbColDecimal.OptionsColumn.AllowEdit = false;
            this.otbColDecimal.Visible = true;
            this.otbColDecimal.VisibleIndex = 4;
            this.otbColDecimal.Width = 126;
            // 
            // otbColPdt
            // 
            this.otbColPdt.Caption = "รูป";
            this.otbColPdt.ColumnEdit = this.repositoryItemPictureEdit1;
            this.otbColPdt.FieldName = "oilColPdt";
            this.otbColPdt.Name = "otbColPdt";
            this.otbColPdt.OptionsColumn.AllowEdit = false;
            this.otbColPdt.Visible = true;
            this.otbColPdt.VisibleIndex = 5;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // olaShoTxt
            // 
            this.olaShoTxt.AutoSize = true;
            this.olaShoTxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaShoTxt.Location = new System.Drawing.Point(179, 9);
            this.olaShoTxt.Name = "olaShoTxt";
            this.olaShoTxt.Size = new System.Drawing.Size(38, 25);
            this.olaShoTxt.TabIndex = 1;
            this.olaShoTxt.Text = "ชื่อ";
            // 
            // olaDate
            // 
            this.olaDate.AutoSize = true;
            this.olaDate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaDate.Location = new System.Drawing.Point(179, 47);
            this.olaDate.Name = "olaDate";
            this.olaDate.Size = new System.Drawing.Size(50, 25);
            this.olaDate.TabIndex = 2;
            this.olaDate.Text = "วันที่";
            // 
            // olaQty
            // 
            this.olaQty.AutoSize = true;
            this.olaQty.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaQty.Location = new System.Drawing.Point(179, 88);
            this.olaQty.Name = "olaQty";
            this.olaQty.Size = new System.Drawing.Size(70, 25);
            this.olaQty.TabIndex = 3;
            this.olaQty.Text = "จำนวน";
            // 
            // otbPrice
            // 
            this.otbPrice.Location = new System.Drawing.Point(184, 141);
            this.otbPrice.Name = "otbPrice";
            this.otbPrice.Size = new System.Drawing.Size(392, 21);
            this.otbPrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ราคา";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "จำนวน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "วันที่";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "ชื่อสินค้า";
            // 
            // opbShowIMG
            // 
            this.opbShowIMG.Location = new System.Drawing.Point(601, 9);
            this.opbShowIMG.Name = "opbShowIMG";
            this.opbShowIMG.Size = new System.Drawing.Size(244, 153);
            this.opbShowIMG.TabIndex = 9;
            this.opbShowIMG.TabStop = false;
            // 
            // wMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 570);
            this.Controls.Add(this.opbShowIMG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otbPrice);
            this.Controls.Add(this.olaQty);
            this.Controls.Add(this.olaDate);
            this.Controls.Add(this.olaShoTxt);
            this.Controls.Add(this.ogdData);
            this.Name = "wMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ogdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbShowIMG)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn otbColPdt;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.Label olaDate;
        private System.Windows.Forms.Label olaQty;
        private System.Windows.Forms.TextBox otbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox opbShowIMG;
    }
}

