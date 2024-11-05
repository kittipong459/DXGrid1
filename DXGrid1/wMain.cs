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

                odtData.Rows.Add("ข้อความตัวอย่างที่ 1", DateTime.Now, 2000, 1500.50);
                odtData.Rows.Add("ข้อความตัวอย่างที่ 2", DateTime.Now, 150450, 1000.26);
                odtData.Rows.Add("ข้อความตัวอย่างที่ 3", DateTime.Now, 1850, 1850);
                odtData.Rows.Add("ข้อความตัวอย่างที่ 4", DateTime.Now, 999000, 880.7858);
                odtData.Rows.Add("ข้อความตัวอย่างที่ 5", DateTime.Now, 10, 15.669);

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
                DataRow oDatRes = ogdDataList.GetFocusedDataRow() as DataRow;
                olaShoTxt.Text = oDatRes.Table.Rows[1]["tDataText"].ToString();
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
