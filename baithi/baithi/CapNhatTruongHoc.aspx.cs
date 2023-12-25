using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baithi
{
    public partial class CapNhatTruongHoc : System.Web.UI.Page
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
            }catch(Exception)
            {
                lblthongbao.Text = "Lỗi kết nối";
            }
        }

        Boolean Kiemtra(string query)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }else { return false; }
        }

        void ThucThi(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void grvtruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from tbl_Truong";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            int dong = grvtruong.SelectedIndex;
            int trang = grvtruong.PageIndex;
            txtmatruong.Text = dataTable.Rows[trang * 3 + dong][0].ToString();
            txttentruong.Text = dataTable.Rows[trang * 3 + dong][1].ToString();
        }

        protected void grvtruong_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvtruong.PageIndex = e.NewPageIndex;
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            txtmatruong.Text = "";
            txttentruong.Text = "";
        }
     
        protected void btnluu_Click(object sender, EventArgs e)
        {
            string kt = "select * from tbl_Truong where MaTruong = '" + txtmatruong.Text + "' or TenTruong=N'" + txttentruong.Text + "'";
            if (Kiemtra(kt))
            {
                lblthongbao.Text = "Mã trường hoặc tên trường đã tồn tại";
            }
            else
            {
                string them = "insert into tbl_Truong values ('" + txtmatruong.Text + "',N'" + txttentruong.Text + "')";
                ThucThi(them);
                HienThi();
            }
        }

        protected void btnsua_Click(object sender, EventArgs e)
        {
            string sua = "update tbl_Truong set TenTruong = N'" + txttentruong.Text + "' where MaTruong='" + txtmatruong.Text + "'";
            ThucThi(sua);
            HienThi();
        }

        protected void btnxoa_Click(object sender, EventArgs e)
        {
            string xoa = "delete tbl_Truong where MaTruong='" + txtmatruong.Text + "'";
            ThucThi(xoa);
            HienThi();
            txtmatruong.Text = "";
            txttentruong.Text = "";
        }
    }
}