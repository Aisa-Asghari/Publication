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
using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class guestlogin : MaterialForm
    {
        public guestlogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan700, Primary.Grey50, Primary.Grey900, Accent.Yellow200, TextShade.WHITE);
        }

        private void Guestlogin_Load(object sender, EventArgs e)
        {
            this.titleGrid.DefaultCellStyle.SelectionForeColor = Color.Cornsilk;
            this.titleGrid.DefaultCellStyle.SelectionBackColor = Color.Black;

            string addConn = "Data Source=X541U;Initial Catalog=Publication;Integrated Security=True";
            SqlConnection conn = new SqlConnection(addConn);
            conn.Open();

            string query00 = "Create View [dbo].[titlesV] As select * from titles Go";
            SqlCommand cmd00 = new SqlCommand(query00, conn);
            cmd00.ExecuteScalar();

            string query0 = "SELECT * from [titlesV]";
            SqlCommand cmd0 = new SqlCommand(query0, conn);
            SqlDataAdapter sda0 = new SqlDataAdapter(cmd0);
            DataTable dt0 = new DataTable();
            sda0.Fill(dt0);
            cmd0.ExecuteScalar();
            titleGrid.DataSource = dt0;

            string query11 = "Create View [dbo].[authorsV] As select * from authors Go";
            SqlCommand cmd11 = new SqlCommand(query11, conn);
            cmd11.ExecuteScalar();

            string query1 = "SELECT * from [authorsV]";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            cmd1.ExecuteScalar();
            authorGrid.DataSource = dt1;

            string query22 = "Create View [dbo].[publishersV] As select * from publishers Go";
            SqlCommand cmd22 = new SqlCommand(query22, conn);
            cmd22.ExecuteScalar();

            string query2 = "SELECT * from [publishersV]";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            cmd2.ExecuteScalar();
            publisherGrid.DataSource = dt2;
            cmd2.ExecuteScalar();

            string query33 = "Create View [dbo].[employeeV] As select * from employee Go";
            SqlCommand cmd33 = new SqlCommand(query33, conn);
            cmd33.ExecuteScalar();

            string query3 = "SELECT * from [employeeV]";
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            cmd3.ExecuteScalar();
            employeeGrid.DataSource = dt3;

            string query44 = "Create View [dbo].[storesV] As select * from stores Go";
            SqlCommand cmd44 = new SqlCommand(query44, conn);
            cmd44.ExecuteScalar();

            string query4 = "SELECT * from [storesV]";
            SqlCommand cmd4 = new SqlCommand(query4, conn);
            SqlDataAdapter sda4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            cmd4.ExecuteScalar();
            storeGrid.DataSource = dt4;

            conn.Close();
        }
        private void Guesthome_Click(object sender, EventArgs e)
        {
            this.Close();
            registerandlogin registerandlogin = new registerandlogin();
            registerandlogin.Show();
        }

        private void Guestclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guestlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            string addConn = "Data Source=X541U;Initial Catalog=Publication;Integrated Security=True";
            SqlConnection conn = new SqlConnection(addConn);
            conn.Open();

            string query00 = "Drop View titlesV";
            SqlCommand cmd00 = new SqlCommand(query00, conn);
            cmd00.ExecuteScalar();

            string query11 = "Drop View authorsV";
            SqlCommand cmd11 = new SqlCommand(query11, conn);
            cmd11.ExecuteScalar();

            string query22 = "Drop View publishersV";
            SqlCommand cmd22 = new SqlCommand(query22, conn);
            cmd22.ExecuteScalar();

            string query33 = "Drop View employeeV";
            SqlCommand cmd33 = new SqlCommand(query33, conn);
            cmd33.ExecuteScalar();

            string query44 = "Drop View storesV";
            SqlCommand cmd44 = new SqlCommand(query44, conn);
            cmd44.ExecuteScalar();

            conn.Close();
        }
    }
}
