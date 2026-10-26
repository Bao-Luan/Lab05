namespace Lab05
{
    partial class frmNhapLieu
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
            label1 = new Label();
            label2 = new Label();
            txtSoDong = new TextBox();
            txtSoCot = new TextBox();
            btnKhoiTao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 73);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Số dòng";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 129);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Số cột";
            label2.UseWaitCursor = true;
            // 
            // txtSoDong
            // 
            txtSoDong.Location = new Point(126, 73);
            txtSoDong.Name = "txtSoDong";
            txtSoDong.Size = new Size(100, 23);
            txtSoDong.TabIndex = 2;
            txtSoDong.UseWaitCursor = true;
            // 
            // txtSoCot
            // 
            txtSoCot.Location = new Point(126, 121);
            txtSoCot.Name = "txtSoCot";
            txtSoCot.Size = new Size(100, 23);
            txtSoCot.TabIndex = 3;
            txtSoCot.UseWaitCursor = true;
            // 
            // btnKhoiTao
            // 
            btnKhoiTao.Location = new Point(258, 73);
            btnKhoiTao.Name = "btnKhoiTao";
            btnKhoiTao.Size = new Size(148, 71);
            btnKhoiTao.TabIndex = 4;
            btnKhoiTao.Text = "Khởi tạo form";
            btnKhoiTao.UseVisualStyleBackColor = true;
            btnKhoiTao.UseWaitCursor = true;
            btnKhoiTao.Click += btnKhoiTao_Click;
            // 
            // frmNhapLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKhoiTao);
            Controls.Add(txtSoCot);
            Controls.Add(txtSoDong);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhapLieu";
            Text = "NhapLieu";
            UseWaitCursor = true;
            Load += frmNhapLieu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSoDong;
        private TextBox txtSoCot;
        private Button btnKhoiTao;
    }
}
