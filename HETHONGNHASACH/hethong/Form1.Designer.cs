namespace hethong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loaisachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem,
            this.dangnhapToolStripMenuItem,
            this.loaisachToolStripMenuItem,
            this.sachToolStripMenuItem,
            this.hoadonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(76, 448);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.hethongToolStripMenuItem.Text = "hethong";
            this.hethongToolStripMenuItem.Click += new System.EventHandler(this.hethong);
            // 
            // dangnhapToolStripMenuItem
            // 
            this.dangnhapToolStripMenuItem.Name = "dangnhapToolStripMenuItem";
            this.dangnhapToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.dangnhapToolStripMenuItem.Text = "dangnhap";
            this.dangnhapToolStripMenuItem.Click += new System.EventHandler(this.danhnhap);
            // 
            // loaisachToolStripMenuItem
            // 
            this.loaisachToolStripMenuItem.Name = "loaisachToolStripMenuItem";
            this.loaisachToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.loaisachToolStripMenuItem.Text = "loaisach";
            this.loaisachToolStripMenuItem.Click += new System.EventHandler(this.loaisach);
            // 
            // sachToolStripMenuItem
            // 
            this.sachToolStripMenuItem.Name = "sachToolStripMenuItem";
            this.sachToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.sachToolStripMenuItem.Text = "sach";
            this.sachToolStripMenuItem.Click += new System.EventHandler(this.sach);
            // 
            // hoadonToolStripMenuItem
            // 
            this.hoadonToolStripMenuItem.Name = "hoadonToolStripMenuItem";
            this.hoadonToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.hoadonToolStripMenuItem.Text = "hoadon";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG NHÀ SÁCH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 448);
            this.Controls.Add(this.label1);
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

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hethongToolStripMenuItem;
        private ToolStripMenuItem dangnhapToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem loaisachToolStripMenuItem;
        private ToolStripMenuItem sachToolStripMenuItem;
        private ToolStripMenuItem hoadonToolStripMenuItem;
    }
}