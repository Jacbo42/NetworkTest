namespace WinFormsApp_Övning5_1_Klient
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
            tbxIPAdress = new TextBox();
            tbxPortnummer = new TextBox();
            groupBox1 = new GroupBox();
            tbxUtkorg = new TextBox();
            btnSend = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Serverns IP-adress";
            // 
            // tbxIPAdress
            // 
            tbxIPAdress.Location = new Point(156, 12);
            tbxIPAdress.Name = "tbxIPAdress";
            tbxIPAdress.Size = new Size(123, 23);
            tbxIPAdress.TabIndex = 2;
            // 
            // tbxPortnummer
            // 
            tbxPortnummer.Location = new Point(156, 41);
            tbxPortnummer.Name = "tbxPortnummer";
            tbxPortnummer.Size = new Size(123, 23);
            tbxPortnummer.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSend);
            groupBox1.Controls.Add(tbxUtkorg);
            groupBox1.Location = new Point(28, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 114);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Utkorg";
            // 
            // tbxUtkorg
            // 
            tbxUtkorg.Location = new Point(6, 22);
            tbxUtkorg.Multiline = true;
            tbxUtkorg.Name = "tbxUtkorg";
            tbxUtkorg.Size = new Size(239, 43);
            tbxUtkorg.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(6, 85);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(239, 23);
            btnSend.TabIndex = 1;
            btnSend.Text = "Sänd";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 49);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 5;
            label2.Text = "Serverns portnummer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 298);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(tbxPortnummer);
            Controls.Add(tbxIPAdress);
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
        private TextBox tbxIPAdress;
        private TextBox tbxPortnummer;
        private GroupBox groupBox1;
        private Button btnSend;
        private TextBox tbxUtkorg;
        private Label label2;
    }
}