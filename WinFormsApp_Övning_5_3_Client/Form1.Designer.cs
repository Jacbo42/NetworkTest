namespace WinFormsApp_Övning_5_3_Client
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
            label1 = new Label();
            tbxIPadress = new TextBox();
            btnAnslut = new Button();
            groupBox1 = new GroupBox();
            btnSend = new Button();
            tbxUtkorg = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Serverns IP-adress";
            // 
            // tbxIPadress
            // 
            tbxIPadress.Location = new Point(131, 6);
            tbxIPadress.Name = "tbxIPadress";
            tbxIPadress.Size = new Size(100, 23);
            tbxIPadress.TabIndex = 1;
            // 
            // btnAnslut
            // 
            btnAnslut.Location = new Point(12, 27);
            btnAnslut.Name = "btnAnslut";
            btnAnslut.Size = new Size(75, 23);
            btnAnslut.TabIndex = 2;
            btnAnslut.Text = "Anslut";
            btnAnslut.UseVisualStyleBackColor = true;
            btnAnslut.Click += btnAnslut_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSend);
            groupBox1.Controls.Add(tbxUtkorg);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 176);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Utkorg";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(6, 147);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(207, 23);
            btnSend.TabIndex = 1;
            btnSend.Text = "Sänd";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbxUtkorg
            // 
            tbxUtkorg.Location = new Point(6, 22);
            tbxUtkorg.Multiline = true;
            tbxUtkorg.Name = "tbxUtkorg";
            tbxUtkorg.Size = new Size(207, 119);
            tbxUtkorg.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 283);
            Controls.Add(groupBox1);
            Controls.Add(btnAnslut);
            Controls.Add(tbxIPadress);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxIPadress;
        private Button btnAnslut;
        private GroupBox groupBox1;
        private Button btnSend;
        private TextBox tbxUtkorg;
    }
}