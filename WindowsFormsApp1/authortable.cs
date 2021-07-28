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
    public partial class authortable : MaterialForm
    {

        public authortable()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan700, Primary.Grey50, Primary.Grey900, Accent.Yellow200, TextShade.WHITE);

            string addConn = "Data Source=X541U;Initial Catalog=Publication;Integrated Security=True";
            SqlConnection conn = new SqlConnection(addConn);
            conn.Open();

            string read = "SELECT * FROM [authors]";
            SqlCommand cmd = new SqlCommand(read, conn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ReadGrid.DataSource = dt;
            InfoGrid.DataSource = dt;
            UGrid.DataSource = dt;
            DGrid.DataSource = dt;
        }
        private void authortable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'publicationDataSet.authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.publicationDataSet.authors);

        }

        private void createauthorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (setAuthorLname.Text != null && setAuthorLname.Text != "" && setAuthorFname.Text != null && setAuthorFname.Text != "")
                {
                    string addConn = "Data Source=X541U;Initial Catalog=Publication;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(addConn);
                    conn.Open();

                    string insert = "INSERT INTO [authors] VALUES (@parametr0,@parametr1,@parametr2,@parametr3,@parametr4)";
                    SqlCommand cmd0 = new SqlCommand(insert, conn);
                    cmd0.Parameters.AddWithValue("@parametr0", setAuthorLname.Text);
                    cmd0.Parameters.AddWithValue("@parametr1", setAuthorFname.Text);
                    cmd0.Parameters.AddWithValue("@parametr2", setAuthorPhone.Text);
                    cmd0.Parameters.AddWithValue("@parametr3", setAuthorAddress.Text);
                    cmd0.Parameters.AddWithValue("@parametr4", setAuthorCity.Text);
                    cmd0.ExecuteNonQuery();
                    MessageBox.Show("Insert Done Successfully");

                    string select = "SELECT * FROM [authors]";
                    SqlCommand cmd1 = new SqlCommand(select, conn);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmd1.ExecuteScalar();

                    ReadGrid.DataSource = dt;
                    InfoGrid.DataSource = dt;
                    UGrid.DataSource = dt;
                    DGrid.DataSource = dt;

                    setAuthorAddress.Text = null;
                    setAuthorCity.Text = null;
                    setAuthorFname.Text = null;
                    setAuthorLname.Text = null;
                    setAuthorPhone.Text = null;
                }
                else MessageBox.Show("Fill Empty Fields");
            }
            catch
            {
                MessageBox.Show("Invalid Operation");
            }
        }

        private void Guestclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Godash_Click(object sender, EventArgs e)
        {
            this.Close();
            main main = new main();
            main.Show();
        }

        private void Guesthome_Click(object sender, EventArgs e)
        {
            this.Close();
            registerandlogin registerandlogin = new registerandlogin();
            registerandlogin.Show();
        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {
            WHEREV.Text = materialTextBox2.Text.ToString();
        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {
            SETV.Text = materialTextBox3.Text.ToString();
        }

        private void idauthorRB_CheckedChanged(object sender, EventArgs e)
        {
            WHEREF.Text = "Au_id";
        }

        private void firstauthorRB_CheckedChanged(object sender, EventArgs e)
        {
            WHEREF.Text = "Au_fname";
        }

        private void lastauthorRB_CheckedChanged(object sender, EventArgs e)
        {
            WHEREF.Text = "Au_lname";
        }

        private void phoneauthorRB_CheckedChanged(object sender, EventArgs e)
        {
            WHEREF.Text = phoneauthorRB.Text.ToString();
        }

        private void cityauthorRB_CheckedChanged_1(object sender, EventArgs e)
        {
            WHEREF.Text = cityauthorRB.Text.ToString();
        }

        private void addressauthorRB_CheckedChanged_1(object sender, EventArgs e)
        {
            WHEREF.Text = addressauthorRB.Text.ToString();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            SETF.Text = "Au_fname";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            SETF.Text = "Au_lname";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            SETF.Text = phoneauthorRB.Text.ToString();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            SETF.Text = addressauthorRB.Text.ToString();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            SETF.Text = cityauthorRB.Text.ToString();
        }

        private void updateauthorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SETF.Text != null && SETF.Text != "" &&
                    SETV.Text != null && SETV.Text != "" &&
                    WHEREF.Text != null && WHEREF.Text != "" &&
                    WHEREV.Text != null && WHEREV.Text != "" &&
                    ss.Text != null && ss.Text != "" &&
                    ww.Text != null && ww.Text != "")
                {
                    string addConn = "Data Source=X541U;Initial Catalog=Publication;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(addConn);
                    conn.Open();

                    string check = "SELECT * FROM [authors] WHERE " + WHEREF.Text + ww.Text + "'" + WHEREV.Text + "'";
                    SqlCommand cmd = new SqlCommand(check, conn);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaa = new SqlDataAdapter(cmd);
                    DataTable dtt = new DataTable();
                    sdaa.Fill(dtt);
                    if (dtt.Rows.Count == 0)
                        MessageBox.Show("Invalid Record");
                    else
                    {
                        string update = "UPDATE [authors] SET " + SETF.Text + ss.Text + "'" + SETV.Text + "'" + " WHERE " + WHEREF.Text + ww.Text + "'" + WHEREV.Text + "'";
                        SqlCommand cmd0 = new SqlCommand(update, conn);
                        cmd0.ExecuteNonQuery();
                        MessageBox.Show("Update Done Successfully");

                        string select = "SELECT * FROM [authors]";
                        SqlCommand cmd1 = new SqlCommand(select, conn);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        cmd1.ExecuteScalar();

                        ReadGrid.DataSource = dt;
                        InfoGrid.DataSource = dt;
                        UGrid.DataSource = dt;
                        DGrid.DataSource = dt;
                    }
                }
                else MessageBox.Show("Fill Empty Fields");
            }
            catch
            {
                MessageBox.Show("Invalid Operation");
            }
        }

        private void DAuthor_TextChanged(object sender, EventArgs e)
        {
            WhereVa.Text = DAuthor.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            WhereFi.Text = "Au_id";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            WhereFi.Text = "Au_fname";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            WhereFi.Text = "Au_lname";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            WhereFi.Text = phoneauthorRB.Text.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            WhereFi.Text = addressauthorRB.Text.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WhereFi.Text = cityauthorRB.Text.ToString();
        }

        private void ww_Click(object sender, EventArgs e)
        {
            ww.Clear();
        }

        private void ss_Click(object sender, EventArgs e)
        {
            ss.Clear();
        }

        private void w_Click(object sender, EventArgs e)
        {
            w.Clear();
        }

        private void deleteauthorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (WhereFi.Text != null && WhereFi.Text != "" &&
                    WhereVa.Text != null && WhereVa.Text != "" &&
                    w.Text != null && w.Text != "")
                {
                    string addConn = "Data Source=X541U;Initial Catalog=Publication;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(addConn);
                    conn.Open();

                    string check = "SELECT * FROM [authors] WHERE "+WhereFi.Text+w.Text+"'"+WhereVa.Text+"'";
                    SqlCommand cmd = new SqlCommand(check, conn);                    
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaa = new SqlDataAdapter(cmd);
                    DataTable dtt = new DataTable();
                    sdaa.Fill(dtt);

                    if (dtt.Rows.Count == 0)
                        MessageBox.Show("Invalid Record");
                    else
                    {
                        string delete = "DELETE FROM [authors] WHERE " + WhereFi.Text + w.Text + "'" + WhereVa.Text + "'";
                        SqlCommand cmd0 = new SqlCommand(delete, conn);
                        cmd0.ExecuteNonQuery();
                        MessageBox.Show("Delete Done Successfully");

                        string select = "SELECT * FROM [authors]";
                        SqlCommand cmd1 = new SqlCommand(select, conn);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        cmd1.ExecuteScalar();

                        ReadGrid.DataSource = dt;
                        InfoGrid.DataSource = dt;
                        UGrid.DataSource = dt;
                        DGrid.DataSource = dt;
                    }
                }
                else MessageBox.Show("Fill Empty Fields");
            }
            catch
            {
                MessageBox.Show("Invalid Operation");
            }
        }
    }
}