namespace WinFormsApp_Övning5_1_Server
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
            groupBox1 = new GroupBox();
            btnTagEmot = new Button();
            tbxInkorg = new TextBox();
            tbxServerPortnummer = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 40);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Serverns portnummer";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTagEmot);
            groupBox1.Controls.Add(tbxInkorg);
            groupBox1.Location = new Point(35, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 134);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inkorg";
            // 
            // btnTagEmot
            // 
            btnTagEmot.Location = new Point(6, 98);
            btnTagEmot.Name = "btnTagEmot";
            btnTagEmot.Size = new Size(210, 23);
            btnTagEmot.TabIndex = 6;
            btnTagEmot.Text = "Tag emot";
            btnTagEmot.UseVisualStyleBackColor = true;
            btnTagEmot.Click += btnTagEmot_Click;
            // 
            // tbxInkorg
            // 
            tbxInkorg.Location = new Point(6, 22);
            tbxInkorg.Multiline = true;
            tbxInkorg.Name = "tbxInkorg";
            tbxInkorg.ScrollBars = ScrollBars.Horizontal;
            tbxInkorg.Size = new Size(210, 70);
            tbxInkorg.TabIndex = 5;
            // 
            // tbxServerPortnummer
            // 
            tbxServerPortnummer.Location = new Point(157, 32);
            tbxServerPortnummer.Name = "tbxServerPortnummer";
            tbxServerPortnummer.Size = new Size(100, 23);
            tbxServerPortnummer.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 220);
            Controls.Add(tbxServerPortnummer);
            Controls.Add(groupBox1);
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
        private GroupBox groupBox1;
        private Button btnTagEmot;
        private TextBox tbxInkorg;
        private TextBox tbxServerPortnummer;
    }
}