namespace lablaydiem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLiDoiBongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemqldoibong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemQualicauthu = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachCauThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLiDoiBongToolStripMenuItem,
            this.danhSachCauThuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLiDoiBongToolStripMenuItem
            // 
            this.quanLiDoiBongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemqldoibong,
            this.menuitemQualicauthu});
            this.quanLiDoiBongToolStripMenuItem.Name = "quanLiDoiBongToolStripMenuItem";
            this.quanLiDoiBongToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.quanLiDoiBongToolStripMenuItem.Text = "QUAN LY DOI BONG";
            this.quanLiDoiBongToolStripMenuItem.Click += new System.EventHandler(this.quanLiDoiBongToolStripMenuItem_Click);
            // 
            // menuitemqldoibong
            // 
            this.menuitemqldoibong.Name = "menuitemqldoibong";
            this.menuitemqldoibong.Size = new System.Drawing.Size(224, 26);
            this.menuitemqldoibong.Text = "Cau Thu";
            this.menuitemqldoibong.Click += new System.EventHandler(this.menuitemqldoibong_Click);
            // 
            // menuitemQualicauthu
            // 
            this.menuitemQualicauthu.Name = "menuitemQualicauthu";
            this.menuitemQualicauthu.Size = new System.Drawing.Size(224, 26);
            this.menuitemQualicauthu.Text = "Doi Bong";
            this.menuitemQualicauthu.Click += new System.EventHandler(this.menuitemQualicauthu_Click);
            // 
            // danhSachCauThuToolStripMenuItem
            // 
            this.danhSachCauThuToolStripMenuItem.Name = "danhSachCauThuToolStripMenuItem";
            this.danhSachCauThuToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.danhSachCauThuToolStripMenuItem.Text = "QUAN LY CAU THU";
            this.danhSachCauThuToolStripMenuItem.Click += new System.EventHandler(this.danhSachCauThuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 468);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLiDoiBongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitemqldoibong;
        private System.Windows.Forms.ToolStripMenuItem menuitemQualicauthu;
        private System.Windows.Forms.ToolStripMenuItem danhSachCauThuToolStripMenuItem;
    }
}

