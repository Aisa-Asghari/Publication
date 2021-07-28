namespace WindowsFormsApp1
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.logo = new System.Windows.Forms.Panel();
            this.crudbtn = new MaterialSkin.Controls.MaterialButton();
            this.subtitlepanel = new System.Windows.Forms.Panel();
            this.crudstoresbtn = new System.Windows.Forms.Button();
            this.crudpublisherbtn = new System.Windows.Forms.Button();
            this.crudauthorbtn = new System.Windows.Forms.Button();
            this.crudtitlebtn = new System.Windows.Forms.Button();
            this.searchbtn = new MaterialSkin.Controls.MaterialButton();
            this.writeCode = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guesthome = new System.Windows.Forms.PictureBox();
            this.guestclose = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.subtitlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guesthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestclose)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.logo);
            this.flowLayoutPanel1.Controls.Add(this.crudbtn);
            this.flowLayoutPanel1.Controls.Add(this.subtitlepanel);
            this.flowLayoutPanel1.Controls.Add(this.searchbtn);
            this.flowLayoutPanel1.Controls.Add(this.writeCode);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 755);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.home__2_1;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(3, 100);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(240, 180);
            this.logo.TabIndex = 0;
            // 
            // crudbtn
            // 
            this.crudbtn.AutoSize = false;
            this.crudbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crudbtn.Depth = 0;
            this.crudbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudbtn.DrawShadows = true;
            this.crudbtn.HighEmphasis = true;
            this.crudbtn.Icon = null;
            this.crudbtn.Location = new System.Drawing.Point(4, 289);
            this.crudbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.crudbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.crudbtn.Name = "crudbtn";
            this.crudbtn.Size = new System.Drawing.Size(225, 45);
            this.crudbtn.TabIndex = 7;
            this.crudbtn.Text = "CRUD";
            this.crudbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.crudbtn.UseAccentColor = false;
            this.crudbtn.UseVisualStyleBackColor = true;
            this.crudbtn.Click += new System.EventHandler(this.Crudbtn_Click);
            // 
            // subtitlepanel
            // 
            this.subtitlepanel.Controls.Add(this.crudstoresbtn);
            this.subtitlepanel.Controls.Add(this.crudpublisherbtn);
            this.subtitlepanel.Controls.Add(this.crudauthorbtn);
            this.subtitlepanel.Controls.Add(this.crudtitlebtn);
            this.subtitlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subtitlepanel.Location = new System.Drawing.Point(3, 343);
            this.subtitlepanel.Name = "subtitlepanel";
            this.subtitlepanel.Size = new System.Drawing.Size(225, 159);
            this.subtitlepanel.TabIndex = 7;
            // 
            // crudstoresbtn
            // 
            this.crudstoresbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudstoresbtn.Location = new System.Drawing.Point(0, 105);
            this.crudstoresbtn.Name = "crudstoresbtn";
            this.crudstoresbtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.crudstoresbtn.Size = new System.Drawing.Size(225, 35);
            this.crudstoresbtn.TabIndex = 5;
            this.crudstoresbtn.Text = "stores";
            this.crudstoresbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crudstoresbtn.UseVisualStyleBackColor = true;
            this.crudstoresbtn.Click += new System.EventHandler(this.Crudstoresbtn_Click_1);
            // 
            // crudpublisherbtn
            // 
            this.crudpublisherbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudpublisherbtn.Location = new System.Drawing.Point(0, 70);
            this.crudpublisherbtn.Name = "crudpublisherbtn";
            this.crudpublisherbtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.crudpublisherbtn.Size = new System.Drawing.Size(225, 35);
            this.crudpublisherbtn.TabIndex = 4;
            this.crudpublisherbtn.Text = "publisher";
            this.crudpublisherbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crudpublisherbtn.UseVisualStyleBackColor = true;
            this.crudpublisherbtn.Click += new System.EventHandler(this.Crudpublisherbtn_Click);
            // 
            // crudauthorbtn
            // 
            this.crudauthorbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudauthorbtn.Location = new System.Drawing.Point(0, 35);
            this.crudauthorbtn.Name = "crudauthorbtn";
            this.crudauthorbtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.crudauthorbtn.Size = new System.Drawing.Size(225, 35);
            this.crudauthorbtn.TabIndex = 3;
            this.crudauthorbtn.Text = "author";
            this.crudauthorbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crudauthorbtn.UseVisualStyleBackColor = true;
            this.crudauthorbtn.Click += new System.EventHandler(this.Crudauthorbtn_Click);
            // 
            // crudtitlebtn
            // 
            this.crudtitlebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudtitlebtn.Location = new System.Drawing.Point(0, 0);
            this.crudtitlebtn.Name = "crudtitlebtn";
            this.crudtitlebtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.crudtitlebtn.Size = new System.Drawing.Size(225, 35);
            this.crudtitlebtn.TabIndex = 2;
            this.crudtitlebtn.Text = "title";
            this.crudtitlebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crudtitlebtn.UseVisualStyleBackColor = true;
            this.crudtitlebtn.Click += new System.EventHandler(this.Crudtitlebtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.AutoSize = false;
            this.searchbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchbtn.Depth = 0;
            this.searchbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbtn.DrawShadows = true;
            this.searchbtn.HighEmphasis = true;
            this.searchbtn.Icon = null;
            this.searchbtn.Location = new System.Drawing.Point(4, 511);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(225, 45);
            this.searchbtn.TabIndex = 8;
            this.searchbtn.Text = "SEARCH";
            this.searchbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchbtn.UseAccentColor = false;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // writeCode
            // 
            this.writeCode.AutoSize = false;
            this.writeCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.writeCode.Depth = 0;
            this.writeCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.writeCode.DrawShadows = true;
            this.writeCode.HighEmphasis = true;
            this.writeCode.Icon = null;
            this.writeCode.Location = new System.Drawing.Point(4, 568);
            this.writeCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.writeCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.writeCode.Name = "writeCode";
            this.writeCode.Size = new System.Drawing.Size(225, 45);
            this.writeCode.TabIndex = 9;
            this.writeCode.Text = "WRITE CODE";
            this.writeCode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.writeCode.UseAccentColor = false;
            this.writeCode.UseVisualStyleBackColor = true;
            this.writeCode.Click += new System.EventHandler(this.Writecode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.readingbook;
            this.pictureBox1.Location = new System.Drawing.Point(554, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // guesthome
            // 
            this.guesthome.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.guesthome.Location = new System.Drawing.Point(1185, 85);
            this.guesthome.Name = "guesthome";
            this.guesthome.Size = new System.Drawing.Size(35, 35);
            this.guesthome.TabIndex = 4;
            this.guesthome.TabStop = false;
            this.guesthome.Click += new System.EventHandler(this.Guesthome_Click);
            // 
            // guestclose
            // 
            this.guestclose.Image = global::WindowsFormsApp1.Properties.Resources.cancel;
            this.guestclose.Location = new System.Drawing.Point(1222, 85);
            this.guestclose.Name = "guestclose";
            this.guestclose.Size = new System.Drawing.Size(35, 35);
            this.guestclose.TabIndex = 3;
            this.guestclose.TabStop = false;
            this.guestclose.Click += new System.EventHandler(this.Guestclose_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 755);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guesthome);
            this.Controls.Add(this.guestclose);
            this.MaximumSize = new System.Drawing.Size(1269, 755);
            this.MinimumSize = new System.Drawing.Size(1269, 755);
            this.Name = "main";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.subtitlepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guesthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestclose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox guesthome;
        private System.Windows.Forms.PictureBox guestclose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel subtitlepanel;
        private MaterialSkin.Controls.MaterialButton crudbtn;
        private System.Windows.Forms.Button crudpublisherbtn;
        private System.Windows.Forms.Button crudauthorbtn;
        private System.Windows.Forms.Button crudtitlebtn;
        private MaterialSkin.Controls.MaterialButton searchbtn;
        private MaterialSkin.Controls.MaterialButton writeCode;
        private System.Windows.Forms.Button crudstoresbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}