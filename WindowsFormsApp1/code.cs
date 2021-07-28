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
    public partial class code : MaterialForm
    {
        public code()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan700, Primary.Grey50, Primary.Grey900, Accent.Yellow200, TextShade.WHITE);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            main main = new main();
            main.Show();
        }

        private void guesthome_Click(object sender, EventArgs e)
        {
            this.Close();
            registerandlogin registerandlogin = new registerandlogin();
            registerandlogin.Show();
        }

        private void guestclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewQuery_Click(object sender, EventArgs e)
        {
            QueryTxt.Clear();
            queryGrid.DataSource = null;
        }

        private void ExecuteQuery_Click(object sender, EventArgs e)
        {
            string addConn = "Data Source=X541U;Initial Catalog=Publication;Integrated Security=True";
            SqlConnection conn = new SqlConnection(addConn);
            conn.Open();

            string query = QueryTxt.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteScalar();

            queryGrid.DataSource = dt;

            conn.Close();
        }
    }
}
