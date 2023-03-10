namespace Bai2
{
    partial class mainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdred = new System.Windows.Forms.RadioButton();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.btnToMau = new System.Windows.Forms.Button();
            this.txtHopMau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Location = new System.Drawing.Point(80, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Giới Tính";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(45, 83);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(54, 24);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(45, 39);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(67, 24);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnToMau);
            this.groupBox2.Controls.Add(this.rdred);
            this.groupBox2.Controls.Add(this.rdXanh);
            this.groupBox2.Location = new System.Drawing.Point(424, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn màu";
            // 
            // rdred
            // 
            this.rdred.AutoSize = true;
            this.rdred.Location = new System.Drawing.Point(45, 83);
            this.rdred.Name = "rdred";
            this.rdred.Size = new System.Drawing.Size(87, 24);
            this.rdred.TabIndex = 1;
            this.rdred.Text = "màu đỏ";
            this.rdred.UseVisualStyleBackColor = true;
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdXanh.Checked = true;
            this.rdXanh.Location = new System.Drawing.Point(45, 39);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(103, 24);
            this.rdXanh.TabIndex = 0;
            this.rdXanh.TabStop = true;
            this.rdXanh.Text = "màu xanh";
            this.rdXanh.UseVisualStyleBackColor = false;
            // 
            // btnToMau
            // 
            this.btnToMau.Location = new System.Drawing.Point(185, 50);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(106, 33);
            this.btnToMau.TabIndex = 2;
            this.btnToMau.Text = "tô màu";
            this.btnToMau.UseVisualStyleBackColor = true;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // txtHopMau
            // 
            this.txtHopMau.Location = new System.Drawing.Point(531, 51);
            this.txtHopMau.Multiline = true;
            this.txtHopMau.Name = "txtHopMau";
            this.txtHopMau.ReadOnly = true;
            this.txtHopMau.Size = new System.Drawing.Size(224, 85);
            this.txtHopMau.TabIndex = 2;
            this.txtHopMau.TextChanged += new System.EventHandler(this.txtHopMau_TextChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHopMau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainForm";
            this.Text = "Bài Tập 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNam;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnToMau;
        private System.Windows.Forms.RadioButton rdred;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.TextBox txtHopMau;
    }
}

