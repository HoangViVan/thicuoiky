using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baithi
{
    public partial class Timkiem : System.Web.UI.Page
    {
        public static string chuoiKN = "Data Source=.;Initial Catalog=QL_SINHVIEN;Integrated Security=True;Encrypt=False";
        public static SqlConnection conn = new SqlConnection(chuoiKN);
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        void HienThi()
        {
            try
            {
                string query = "select * from tbl_Truong";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                grvtruong.DataSource = dataTable;
                grvtruong.DataBind();
            }
            catch (Exception)
            {
                lblthongbao.Text = "Lỗi kết nối";
            }
        }
    }
}