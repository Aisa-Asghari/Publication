using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class main : MaterialForm
    {
        public main()
        {
            InitializeComponent();
            customizeDesign();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan700, Primary.Grey50, Primary.Grey900, Accent.Yellow200, TextShade.WHITE);
        }
        private void customizeDesign()
        {
            subtitlepanel.Visible = false;
        }

        private void Guesthome_Click(object sender, EventArgs e)
        {
            this.Close();
            registerandlogin registerandlogin = new registerandlogin();
            registerandlogin.Show();
        }

        private void Crudbtn_Click(object sender, EventArgs e)
        {
            if (subtitlepanel.Visible == true)
                subtitlepanel.Visible = false;
            if (subtitlepanel.Visible == false)
                subtitlepanel.Visible = true;
        }

        private void Crudtitlebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            titletable titletable = new titletable();
            titletable.Show();
        }

        private void Crudauthorbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            authortable authortable = new authortable();
            authortable.Show();
        }

        private void Crudpublisherbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            publishertable publishertable = new publishertable();
            publishertable.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            search search = new search();
            search.Show();
        }

        private void Writecode_Click(object sender, EventArgs e)
        {
            this.Hide();
            code code = new code();
            code.Show();
        }

        private void Crudstoresbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            storestable storestable = new storestable();
            storestable.Show();
        }

        private void Guestclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}