namespace WinFormsApp_Övning5_2_Client
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
            tbxIPadress = new TextBox();
            label1 = new Label();
            btnAnslut = new Button();
            btnSend = new Button();
            label2 = new Label();
            tbxInput = new TextBox();
            SuspendLayout();
            // 
            // tbxIPadress
            // 
            tbxIPadress.Location = new Point(87, 19);
            tbxIPadress.Name = "tbxIPadress";
            tbxIPadress.Size = new Size(100, 23);
            tbxIPadress.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "IP-adress";
            // 
            // btnAnslut
            // 
            btnAnslut.Location = new Point(245, 19);
            btnAnslut.Name = "btnAnslut";
            btnAnslut.Size = new Size(75, 23);
            btnAnslut.TabIndex = 2;
            btnAnslut.Text = "Anslut";
            btnAnslut.UseVisualStyleBackColor = true;
            btnAnslut.Click += btnAnslut_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(245, 182);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 3;
            btnSend.Text = " Sänd";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // tbxInput
            // 
            tbxInput.Location = new Point(12, 73);
            tbxInput.Multiline = true;
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(308, 103);
            tbxInput.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxInput);
            Controls.Add(label2);
            Controls.Add(btnSend);
            Controls.Add(btnAnslut);
            Controls.Add(label1);
            Controls.Add(tbxIPadress);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxIPadress;
        private Label label1;
        private Button btnAnslut;
        private Button btnSend;
        private Label label2;
        private TextBox tbxInput;
    }
}