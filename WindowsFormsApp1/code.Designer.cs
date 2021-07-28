namespace WindowsFormsApp1
{
    partial class code
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.godash = new System.Windows.Forms.PictureBox();
            this.guesthome = new System.Windows.Forms.PictureBox();
            this.guestclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QueryTxt = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.ExecuteQuery = new MaterialSkin.Controls.MaterialButton();
            this.NewQuery = new MaterialSkin.Controls.MaterialButton();
            this.queryGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.godash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guesthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // godash
            // 
            this.godash.Image = global::WindowsFormsApp1.Properties.Resources.godashbord;
            this.godash.Location = new System.Drawing.Point(1179, 85);
            this.godash.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.godash.Name = "godash";
            this.godash.Size = new System.Drawing.Size(35, 35);
            this.godash.TabIndex = 10;
            this.godash.TabStop = false;
            this.godash.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // guesthome
            // 
            this.guesthome.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.guesthome.Location = new System.Drawing.Point(1138, 85);
            this.guesthome.Name = "guesthome";
            this.guesthome.Size = new System.Drawing.Size(35, 35);
            this.guesthome.TabIndex = 9;
            this.guesthome.TabStop = false;
            this.guesthome.Click += new System.EventHandler(this.guesthome_Click);
            // 
            // guestclose
            // 
            this.guestclose.Image = global::WindowsFormsApp1.Properties.Resources.cancel;
            this.guestclose.Location = new System.Drawing.Point(1222, 85);
            this.guestclose.Name = "guestclose";
            this.guestclose.Size = new System.Drawing.Size(35, 35);
            this.guestclose.TabIndex = 8;
            this.guestclose.TabStop = false;
            this.guestclose.Click += new System.EventHandler(this.guestclose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "HERE YOU CAN WRITE SQL CODES!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QueryTxt
            // 
            this.QueryTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QueryTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryTxt.Depth = 0;
            this.QueryTxt.Font = new System.Drawing.Font("Source Code Pro", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QueryTxt.Hint = "";
            this.QueryTxt.Location = new System.Drawing.Point(14, 144);
            this.QueryTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.QueryTxt.Name = "QueryTxt";
            this.QueryTxt.Size = new System.Drawing.Size(1245, 200);
            this.QueryTxt.TabIndex = 12;
            this.QueryTxt.Text = "";
            // 
            // ExecuteQuery
            // 
            this.ExecuteQuery.AutoSize = false;
            this.ExecuteQuery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExecuteQuery.Depth = 0;
            this.ExecuteQuery.DrawShadows = true;
            this.ExecuteQuery.HighEmphasis = true;
            this.ExecuteQuery.Icon = null;
            this.ExecuteQuery.Location = new System.Drawing.Point(516, 85);
            this.ExecuteQuery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExecuteQuery.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExecuteQuery.Name = "ExecuteQuery";
            this.ExecuteQuery.Size = new System.Drawing.Size(275, 50);
            this.ExecuteQuery.TabIndex = 13;
            this.ExecuteQuery.Text = "Execute Query";
            this.ExecuteQuery.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExecuteQuery.UseAccentColor = false;
            this.ExecuteQuery.UseVisualStyleBackColor = true;
            this.ExecuteQuery.Click += new System.EventHandler(this.ExecuteQuery_Click);
            // 
            // NewQuery
            // 
            this.NewQuery.AutoSize = false;
            this.NewQuery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewQuery.Depth = 0;
            this.NewQuery.DrawShadows = true;
            this.NewQuery.HighEmphasis = true;
            this.NewQuery.Icon = null;
            this.NewQuery.Location = new System.Drawing.Point(856, 85);
            this.NewQuery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NewQuery.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewQuery.Name = "NewQuery";
            this.NewQuery.Size = new System.Drawing.Size(275, 50);
            this.NewQuery.TabIndex = 14;
            this.NewQuery.Text = "New Query";
            this.NewQuery.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.NewQuery.UseAccentColor = false;
            this.NewQuery.UseVisualStyleBackColor = true;
            this.NewQuery.Click += new System.EventHandler(this.NewQuery_Click);
            // 
            // queryGrid
            // 
            this.queryGrid.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.queryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryGrid.GridColor = System.Drawing.Color.Gray;
            this.queryGrid.Location = new System.Drawing.Point(12, 350);
            this.queryGrid.Name = "queryGrid";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.queryGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.queryGrid.RowTemplate.Height = 24;
            this.queryGrid.Size = new System.Drawing.Size(1243, 393);
            this.queryGrid.TabIndex = 15;
            // 
            // code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 755);
            this.Controls.Add(this.queryGrid);
            this.Controls.Add(this.NewQuery);
            this.Controls.Add(this.ExecuteQuery);
            this.Controls.Add(this.QueryTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.godash);
            this.Controls.Add(this.guesthome);
            this.Controls.Add(this.guestclose);
            this.MinimumSize = new System.Drawing.Size(1269, 755);
            this.Name = "code";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.godash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guesthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox godash;
        private System.Windows.Forms.PictureBox guesthome;
        private System.Windows.Forms.PictureBox guestclose;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox QueryTxt;
        private MaterialSkin.Controls.MaterialButton ExecuteQuery;
        private MaterialSkin.Controls.MaterialButton NewQuery;
        private System.Windows.Forms.DataGridView queryGrid;
    }
}