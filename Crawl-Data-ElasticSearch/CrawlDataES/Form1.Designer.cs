
namespace CrawlDataES
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pncrawl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.page = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.dgvCrawldata = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfind = new System.Windows.Forms.TextBox();
            this.rtblistlink = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pncrawl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrawldata)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pncrawl
            // 
            this.pncrawl.Controls.Add(this.panel2);
            this.pncrawl.Controls.Add(this.panel1);
            this.pncrawl.Location = new System.Drawing.Point(12, 3);
            this.pncrawl.Name = "pncrawl";
            this.pncrawl.Size = new System.Drawing.Size(1540, 707);
            this.pncrawl.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.page);
            this.panel2.Controls.Add(this.next);
            this.panel2.Controls.Add(this.prev);
            this.panel2.Controls.Add(this.dgvCrawldata);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(647, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 666);
            this.panel2.TabIndex = 2;
            // 
            // page
            // 
            this.page.AutoSize = true;
            this.page.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page.Location = new System.Drawing.Point(753, 637);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(0, 19);
            this.page.TabIndex = 13;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(788, 629);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 34);
            this.next.TabIndex = 12;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev.Location = new System.Drawing.Point(662, 629);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(75, 34);
            this.prev.TabIndex = 11;
            this.prev.Text = "prev";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // dgvCrawldata
            // 
            this.dgvCrawldata.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvCrawldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrawldata.Location = new System.Drawing.Point(42, 70);
            this.dgvCrawldata.Name = "dgvCrawldata";
            this.dgvCrawldata.RowHeadersWidth = 51;
            this.dgvCrawldata.RowTemplate.Height = 24;
            this.dgvCrawldata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCrawldata.Size = new System.Drawing.Size(821, 553);
            this.dgvCrawldata.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết Quả";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnfind);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbfind);
            this.panel1.Controls.Add(this.rtblistlink);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 670);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tìm Kiếm Theo Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng Thái";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 517);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 27);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Tất Cả",
            "Thành Công",
            "Lỗi"});
            this.cbStatus.Location = new System.Drawing.Point(25, 614);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(155, 27);
            this.cbStatus.TabIndex = 8;
            this.cbStatus.Text = "Tất Cả";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(25, 487);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(221, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lấy Thông Tin Và Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfind.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.ForeColor = System.Drawing.Color.Black;
            this.btnfind.Location = new System.Drawing.Point(534, 610);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(86, 33);
            this.btnfind.TabIndex = 6;
            this.btnfind.Text = "Tìm Kiếm";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nội Dung hoặc Link Cần Tìm";
            // 
            // tbfind
            // 
            this.tbfind.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfind.Location = new System.Drawing.Point(232, 610);
            this.tbfind.Multiline = true;
            this.tbfind.Name = "tbfind";
            this.tbfind.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbfind.Size = new System.Drawing.Size(266, 33);
            this.tbfind.TabIndex = 4;
            this.tbfind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtblistlink
            // 
            this.rtblistlink.Location = new System.Drawing.Point(25, 123);
            this.rtblistlink.Name = "rtblistlink";
            this.rtblistlink.Size = new System.Drawing.Size(595, 344);
            this.rtblistlink.TabIndex = 2;
            this.rtblistlink.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Vào Danh Sách Bài Viết Muốn Lấy Thông Tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Bài Viết";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.LoadAgentData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 713);
            this.Controls.Add(this.pncrawl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pncrawl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrawldata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pncrawl;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvCrawldata;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnfind;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbfind;
        public System.Windows.Forms.RichTextBox rtblistlink;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label page;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

