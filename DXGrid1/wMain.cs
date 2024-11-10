using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXGrid1
{
    public partial class wMain : DevExpress.XtraEditors.XtraForm
    {
        public wMain()
        {
            InitializeComponent();
            
            try
            {
                ogdData.DataSource = W_SEToSetDataExample();
            }
            catch (Exception ex) {

            }
            finally
            {

            }
        }

        private DataTable W_SEToSetDataExample()
        {
            DataTable odtData = new DataTable();

            try
            {
                odtData = new DataTable();
                odtData.Columns.Add("tDataText", typeof(string));
                odtData.Columns.Add("dDataDateTime", typeof(DateTime));
                odtData.Columns.Add("nDataNumber", typeof(int));
                odtData.Columns.Add("cDataDecimal", typeof(decimal));
                odtData.Columns.Add("oilColPdt", typeof(Image));


                odtData.Rows.Add("ต้มยำกุ้ง", DateTime.Now, 2000, 1500.50,Properties.Resources.f1m);
                odtData.Rows.Add("ส้มตำ", DateTime.Now, 150450, 1000.26, Properties.Resources.f2m);
                odtData.Rows.Add("ก๋วยเตี๋ยว", DateTime.Now, 1850, 1850, Properties.Resources.f3m);
                odtData.Rows.Add("ลาบหมู", DateTime.Now, 999000, 880.7858, Properties.Resources.f4m);

            }
            catch (Exception)
            {
                odtData = null;
            }
            finally
            {

            }

            return odtData;
        }

        private void ogdData_Click(object sender, EventArgs e)
        {
            try
            {
               // int nRow = ogdDataList.RowCellClick;
                DataRow oDatRes = ogdDataList.GetFocusedDataRow() as DataRow;
                olaShoTxt.Text = oDatRes["tDataText"].ToString();
                otbPrice.Text = oDatRes["cDataDecimal"].ToString();
                olaDate.Text = oDatRes["dDataDateTime"].ToString();
                olaQty.Text = oDatRes["nDataNumber"].ToString();

                Image oImg = (Image)oDatRes["oilColPdt"];
                opbShowIMG.Image = oImg;

                //olaShoTxt.Text = "5555";

            }
            catch (Exception oEx) {
                MessageBox.Show(oEx.Message);
            }
            finally
            {

            }
           
        }

    }
}
