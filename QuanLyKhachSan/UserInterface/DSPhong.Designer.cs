namespace QUANLYKHACHSAN.UserInterface
{
    partial class DSPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSPhong));
            this.contextMenuStripDangKy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dangKyPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.contextMenuStripDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripDangKy
            // 
            this.contextMenuStripDangKy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangKyPhongToolStripMenuItem,
            this.traPhongToolStripMenuItem});
            this.contextMenuStripDangKy.Name = "contextMenuStripDangKy";
            this.contextMenuStripDangKy.Size = new System.Drawing.Size(158, 48);
            // 
            // dangKyPhongToolStripMenuItem
            // 
            this.dangKyPhongToolStripMenuItem.Name = "dangKyPhongToolStripMenuItem";
            this.dangKyPhongToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dangKyPhongToolStripMenuItem.Text = "Dang ky phong";
            this.dangKyPhongToolStripMenuItem.Click += new System.EventHandler(this.dangKyPhongToolStripMenuItem_Click);
            // 
            // traPhongToolStripMenuItem
            // 
            this.traPhongToolStripMenuItem.Name = "traPhongToolStripMenuItem";
            this.traPhongToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.traPhongToolStripMenuItem.Text = "Tra phong";
            this.traPhongToolStripMenuItem.Click += new System.EventHandler(this.traPhongToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "NhaCungUng.png");
            this.imageList1.Images.SetKeyName(1, "CaNhan.png");
            this.imageList1.Images.SetKeyName(2, "CaNhan2.png");
            // 
            // listViewEx1
            // 
            // 
            // 
            // 
            this.listViewEx1.Border.Class = "ListViewBorder";
            this.listViewEx1.ContextMenuStrip = this.contextMenuStripDangKy;
            this.listViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEx1.LargeImageList = this.imageList1;
            this.listViewEx1.Location = new System.Drawing.Point(0, 0);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(534, 345);
            this.listViewEx1.TabIndex = 0;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            // 
            // DSPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(534, 345);
            this.Controls.Add(this.listViewEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DSPhong";
            this.Text = "  Danh Sach Phong";
            this.contextMenuStripDangKy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDangKy;
        private System.Windows.Forms.ToolStripMenuItem dangKyPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traPhongToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewEx1;





    }
}