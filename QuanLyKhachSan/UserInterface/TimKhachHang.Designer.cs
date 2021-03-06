namespace QUANLYKHACHSAN.UserInterface
{
    partial class TimKhachHang
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbtimKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnHuyBo = new DevComponents.DotNetBar.ButtonX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(85, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(141, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "KHÁCH HÀNG";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Navy;
            this.labelX2.Location = new System.Drawing.Point(12, 69);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Khách hàng";
            // 
            // cmbtimKH
            // 
            this.cmbtimKH.DisplayMember = "Text";
            this.cmbtimKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtimKH.FormattingEnabled = true;
            this.cmbtimKH.ItemHeight = 14;
            this.cmbtimKH.Location = new System.Drawing.Point(106, 71);
            this.cmbtimKH.Name = "cmbtimKH";
            this.cmbtimKH.Size = new System.Drawing.Size(159, 20);
            this.cmbtimKH.TabIndex = 2;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuyBo.Image = global::QUANLYKHACHSAN.Properties.Resources.stop;
            this.btnHuyBo.Location = new System.Drawing.Point(165, 119);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(82, 30);
            this.btnHuyBo.TabIndex = 3;
            this.btnHuyBo.Text = "Hủy bỏ";
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDongY.Image = global::QUANLYKHACHSAN.Properties.Resources.Ok;
            this.btnDongY.Location = new System.Drawing.Point(59, 119);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(82, 30);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            // 
            // TimKhachHang
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuyBo;
            this.ClientSize = new System.Drawing.Size(292, 190);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.cmbtimKH);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TimKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TimKhachHang";
            this.Load += new System.EventHandler(this.TimKhachHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbtimKH;
        private DevComponents.DotNetBar.ButtonX btnHuyBo;
        private DevComponents.DotNetBar.ButtonX btnDongY;
    }
}