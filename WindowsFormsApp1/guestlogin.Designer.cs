namespace WindowsFormsApp1
{
    partial class guestlogin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guesthome = new System.Windows.Forms.PictureBox();
            this.guestclose = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.storeGrid = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.publisherGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.authorGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.titleGrid = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guesthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestclose)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleGrid)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // guesthome
            // 
            this.guesthome.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.guesthome.Location = new System.Drawing.Point(1179, 100);
            this.guesthome.Name = "guesthome";
            this.guesthome.Size = new System.Drawing.Size(35, 35);
            this.guesthome.TabIndex = 2;
            this.guesthome.TabStop = false;
            this.guesthome.Click += new System.EventHandler(this.Guesthome_Click);
            // 
            // guestclose
            // 
            this.guestclose.Image = global::WindowsFormsApp1.Properties.Resources.cancel;
            this.guestclose.Location = new System.Drawing.Point(1214, 100);
            this.guestclose.Name = "guestclose";
            this.guestclose.Size = new System.Drawing.Size(35, 35);
            this.guestclose.TabIndex = 1;
            this.guestclose.TabStop = false;
            this.guestclose.Click += new System.EventHandler(this.Guestclose_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage5.Controls.Add(this.storeGrid);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1235, 576);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Stores";
            // 
            // storeGrid
            // 
            this.storeGrid.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.storeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeGrid.GridColor = System.Drawing.Color.Gray;
            this.storeGrid.Location = new System.Drawing.Point(0, 0);
            this.storeGrid.Name = "storeGrid";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.storeGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.storeGrid.RowTemplate.Height = 24;
            this.storeGrid.Size = new System.Drawing.Size(1235, 576);
            this.storeGrid.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage4.Controls.Add(this.employeeGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1235, 576);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Employee";
            // 
            // employeeGrid
            // 
            this.employeeGrid.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeGrid.GridColor = System.Drawing.Color.Gray;
            this.employeeGrid.Location = new System.Drawing.Point(0, 0);
            this.employeeGrid.Name = "employeeGrid";
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.employeeGrid.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.employeeGrid.RowTemplate.Height = 24;
            this.employeeGrid.Size = new System.Drawing.Size(1235, 576);
            this.employeeGrid.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage3.Controls.Add(this.publisherGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1235, 576);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Publisher";
            // 
            // publisherGrid
            // 
            this.publisherGrid.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.publisherGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publisherGrid.GridColor = System.Drawing.Color.Gray;
            this.publisherGrid.Location = new System.Drawing.Point(0, 0);
            this.publisherGrid.Name = "publisherGrid";
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.publisherGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.publisherGrid.RowTemplate.Height = 24;
            this.publisherGrid.Size = new System.Drawing.Size(1235, 576);
            this.publisherGrid.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage2.Controls.Add(this.authorGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Author";
            // 
            // authorGrid
            // 
            this.authorGrid.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.authorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorGrid.GridColor = System.Drawing.Color.Gray;
            this.authorGrid.Location = new System.Drawing.Point(3, 3);
            this.authorGrid.Name = "authorGrid";
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.authorGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.authorGrid.RowTemplate.Height = 24;
            this.authorGrid.Size = new System.Drawing.Size(1229, 570);
            this.authorGrid.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.titleGrid);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Gray;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Title";
            // 
            // titleGrid
            // 
            this.titleGrid.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.titleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.titleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleGrid.GridColor = System.Drawing.Color.Gray;
            this.titleGrid.Location = new System.Drawing.Point(3, 3);
            this.titleGrid.Name = "titleGrid";
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.titleGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.titleGrid.RowTemplate.Height = 24;
            this.titleGrid.Size = new System.Drawing.Size(1229, 570);
            this.titleGrid.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(14, 138);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1243, 605);
            this.tabControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1164, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "HERE YOU CAN VIEW TABLES!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guestlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 755);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guesthome);
            this.Controls.Add(this.guestclose);
            this.Controls.Add(this.tabControl);
            this.Name = "guestlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.guestlogin_FormClosed);
            this.Load += new System.EventHandler(this.Guestlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guesthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestclose)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storeGrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.publisherGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titleGrid)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox guestclose;
        private System.Windows.Forms.PictureBox guesthome;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView titleGrid;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView storeGrid;
        private System.Windows.Forms.DataGridView employeeGrid;
        private System.Windows.Forms.DataGridView publisherGrid;
        private System.Windows.Forms.DataGridView authorGrid;
        private System.Windows.Forms.Label label1;
    }
}