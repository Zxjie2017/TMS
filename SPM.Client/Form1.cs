using SPM.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM.Client
{
    public partial class DBManage : Form
    {
        public DBManage()
        {
            InitializeComponent();
        }

        private void btn_textConn_Click(object sender, EventArgs e)
        {

            var tbName = txtTbName.Text;
            var sqlStr = "select column_name as ColumnName,data_type as ColumnType from information_schema.columns where table_name = '{0}'";


            foreach (DataGridViewRow dr in gv_TbView.Rows)
            {
             
                if (Convert.ToBoolean( dr.Cells["selected"].Value))
                {
                    var dt = MySqlHelper.GetDataSet(string.Format(sqlStr, dr.Cells["name"].Value.ToString())).Tables[0];

                    StringBuilder sbDtoStr = new StringBuilder();
                    StringBuilder sbEntityStr = new StringBuilder();
                    var name = Commnon.replaceUnderlineAndfirstToUpper(dr.Cells["name"].Value.ToString(), "_", "");
                    
                    foreach (DataRow item in dt.Rows)
                    {
                        var ConvertName = Commnon.replaceUnderlineAndfirstToUpper(item["ColumnName"].ToString(), "_", "");
                        var vale = $"public {item["ColumnType"].ColumnTypeConvert()} {ConvertName} " + " {get;set;}";
                        var AsName = $"[Alias(\"{ item["ColumnName"]}\")]";
                        sbDtoStr.AppendLine(vale);
                        sbEntityStr.AppendLine(AsName);
                        sbEntityStr.AppendLine(vale);
                    }
                    txtDto.Text = InitClass(name + "s", sbDtoStr.ToString());
                    txtEntity.Text = InitClass(name, sbEntityStr.ToString());
                    Commnon.Write(name+"s.cs", InitClass(name+"s",sbDtoStr.ToString()));
                    Commnon.Write(name+".cs", InitClass(name, sbEntityStr.ToString()));
                }
            }
        }

        private void gv_TbView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void DBManage_Load(object sender, EventArgs e)
        {
            var queryAllTbStr = "select 0 as selected, name,crdate from sysobjects where xtype in('U','V')";
            var tbDt = MySqlHelper.GetDataSet(queryAllTbStr).Tables[0];
            gv_TbView.DataSource = tbDt;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            var queryAllTbStr = $"select  0 as selected, name,crdate from sysobjects where name like'%{txtTbName.Text}%' AND  xtype in('U','V')";
            var tbDt = MySqlHelper.GetDataSet(queryAllTbStr).Tables[0];
            gv_TbView.DataSource = tbDt;
        }

        private string InitClass(string className,string context)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("public class "+ className);
            sb.AppendLine("{");
            sb.AppendLine(context);
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
