using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace QLDANGKIMH
{
    public partial class frmMonHoc : Form
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
        public void loadcboloaimon()
        {
            conn.Open();
            string query = "SELECT  * FROM loaimon ";

            SqlCommand cmd = new SqlCommand(query, conn);

            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }
            cbLoaiMon.DataSource = t1;
            cbLoaiMon.DisplayMember = "Tenloai";
            cbLoaiMon.ValueMember = "Maloai";
            colLoaimon.DataSource = t1;
            colLoaimon.DisplayMember = "Tenloai";
            colLoaimon.ValueMember = "Maloai";

            conn.Close();

        }
        public void load_monhoc()
        {
         
            conn.Open();
            string query = "SELECT  ROW_NUMBER() OVER(ORDER BY mamh ASC) AS stt,mamh,tenmh,loaimon,sotiet FROM monhoc ";

            SqlCommand cmd = new SqlCommand(query, conn);

            DataTable t1 = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(t1);
            }
            dgvMonHoc.DataSource = t1;
            conn.Close();
        }

        public void add_monhoc()
        {
            try
            {
              //  SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
                //conn.Open();
                //string query = "INSERT INTO monhoc (mamh,tenmh,sotiet) values ('" + txtMaMH.Text + "', '" + txtTenMH.Text + "', '" +Convert.ToInt32( txtSoTiet.Text) + "')";

                //SqlCommand cmd = new SqlCommand(query, conn);
                //load_monhoc();+

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText ="INSERT INTO monhoc (mamh,tenmh,loaimon,sotiet) values ('" + txtMaMH.Text + "', '" + txtTenMH.Text + "','"+cbLoaiMon.SelectedValue.ToString()+"', '" +Convert.ToInt32( txtSoTiet.Text) + "')";
                cmd.Connection = conn;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                load_monhoc();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            loadcboloaimon();
            load_monhoc();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            add_monhoc();
        }

        private void txtTenMH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
