namespace YazLab1
{
    partial class AdminPage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.Button();
            this.deletetxt = new System.Windows.Forms.Button();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.useridtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bookdeletetxt = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.urlltxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.urlmtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.urlstxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.publishertxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.yoptxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bookauthortxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.booktitletxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1413, 967);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Edit);
            this.tabPage1.Controls.Add(this.deletetxt);
            this.tabPage1.Controls.Add(this.Passwordtxt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.agetxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.locationtxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.useridtxt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1405, 938);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 886);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(135, 222);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Edit:";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // deletetxt
            // 
            this.deletetxt.Location = new System.Drawing.Point(135, 164);
            this.deletetxt.Name = "deletetxt";
            this.deletetxt.Size = new System.Drawing.Size(75, 23);
            this.deletetxt.TabIndex = 8;
            this.deletetxt.Text = "Delete";
            this.deletetxt.UseVisualStyleBackColor = true;
            this.deletetxt.Click += new System.EventHandler(this.deletetxt_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(110, 109);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(100, 22);
            this.Passwordtxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(110, 81);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(100, 22);
            this.agetxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age:";
            // 
            // locationtxt
            // 
            this.locationtxt.Location = new System.Drawing.Point(110, 53);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(100, 22);
            this.locationtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // useridtxt
            // 
            this.useridtxt.Location = new System.Drawing.Point(110, 25);
            this.useridtxt.Name = "useridtxt";
            this.useridtxt.Size = new System.Drawing.Size(100, 22);
            this.useridtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User-ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.bookdeletetxt);
            this.tabPage2.Controls.Add(this.editbtn);
            this.tabPage2.Controls.Add(this.addbtn);
            this.tabPage2.Controls.Add(this.urlltxt);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.urlmtxt);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.urlstxt);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.publishertxt);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.yoptxt);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.bookauthortxt);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.booktitletxt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.isbntxt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1405, 938);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Book Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(412, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(964, 868);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // bookdeletetxt
            // 
            this.bookdeletetxt.Location = new System.Drawing.Point(207, 377);
            this.bookdeletetxt.Name = "bookdeletetxt";
            this.bookdeletetxt.Size = new System.Drawing.Size(75, 23);
            this.bookdeletetxt.TabIndex = 18;
            this.bookdeletetxt.Text = "Delete";
            this.bookdeletetxt.UseVisualStyleBackColor = true;
            this.bookdeletetxt.Click += new System.EventHandler(this.bookdeletetxt_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(207, 338);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 17;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(207, 292);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 16;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // urlltxt
            // 
            this.urlltxt.Location = new System.Drawing.Point(182, 238);
            this.urlltxt.Name = "urlltxt";
            this.urlltxt.Size = new System.Drawing.Size(100, 22);
            this.urlltxt.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Image-URL-L:";
            // 
            // urlmtxt
            // 
            this.urlmtxt.Location = new System.Drawing.Point(182, 210);
            this.urlmtxt.Name = "urlmtxt";
            this.urlmtxt.Size = new System.Drawing.Size(100, 22);
            this.urlmtxt.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Image-URL-M:";
            // 
            // urlstxt
            // 
            this.urlstxt.Location = new System.Drawing.Point(182, 182);
            this.urlstxt.Name = "urlstxt";
            this.urlstxt.Size = new System.Drawing.Size(100, 22);
            this.urlstxt.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Image-URL-S:";
            // 
            // publishertxt
            // 
            this.publishertxt.Location = new System.Drawing.Point(182, 154);
            this.publishertxt.Name = "publishertxt";
            this.publishertxt.Size = new System.Drawing.Size(100, 22);
            this.publishertxt.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Publisher:";
            // 
            // yoptxt
            // 
            this.yoptxt.Location = new System.Drawing.Point(182, 126);
            this.yoptxt.Name = "yoptxt";
            this.yoptxt.Size = new System.Drawing.Size(100, 22);
            this.yoptxt.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Year of Publication:";
            // 
            // bookauthortxt
            // 
            this.bookauthortxt.Location = new System.Drawing.Point(182, 98);
            this.bookauthortxt.Name = "bookauthortxt";
            this.bookauthortxt.Size = new System.Drawing.Size(100, 22);
            this.bookauthortxt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Book-Author:";
            // 
            // booktitletxt
            // 
            this.booktitletxt.Location = new System.Drawing.Point(182, 70);
            this.booktitletxt.Name = "booktitletxt";
            this.booktitletxt.Size = new System.Drawing.Size(100, 22);
            this.booktitletxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Book-Title";
            // 
            // isbntxt
            // 
            this.isbntxt.Location = new System.Drawing.Point(182, 42);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(100, 22);
            this.isbntxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ISBN:";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 967);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox useridtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button deletetxt;
        private System.Windows.Forms.TextBox urlltxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox urlmtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox urlstxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox publishertxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox yoptxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bookauthortxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox booktitletxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bookdeletetxt;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button addbtn;
    }
}