namespace WinFormsApp_Övning5_2_Server
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
            btnStartaServer = new Button();
            label1 = new Label();
            tbxInkorg = new TextBox();
            btnTaEmotMeddelande = new Button();
            SuspendLayout();
            // 
            // btnStartaServer
            // 
            btnStartaServer.Location = new Point(12, 20);
            btnStartaServer.Name = "btnStartaServer";
            btnStartaServer.Size = new Size(241, 23);
            btnStartaServer.TabIndex = 0;
            btnStartaServer.Text = "Starta Server";
            btnStartaServer.UseVisualStyleBackColor = true;
            btnStartaServer.Click += btnStartaServer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Inkorg";
            // 
            // tbxInkorg
            // 
            tbxInkorg.Location = new Point(12, 64);
            tbxInkorg.Multiline = true;
            tbxInkorg.Name = "tbxInkorg";
            tbxInkorg.Size = new Size(241, 91);
            tbxInkorg.TabIndex = 2;
            // 
            // btnTaEmotMeddelande
            // 
            btnTaEmotMeddelande.Location = new Point(35, 189);
            btnTaEmotMeddelande.Name = "btnTaEmotMeddelande";
            btnTaEmotMeddelande.Size = new Size(185, 23);
            btnTaEmotMeddelande.TabIndex = 3;
            btnTaEmotMeddelande.Text = "Ta emot ett meddelande";
            btnTaEmotMeddelande.UseVisualStyleBackColor = true;
            btnTaEmotMeddelande.Click += btnTaEmotMeddelande_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 224);
            Controls.Add(btnTaEmotMeddelande);
            Controls.Add(tbxInkorg);
            Controls.Add(label1);
            Controls.Add(btnStartaServer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartaServer;
        private Label label1;
        private TextBox tbxInkorg;
        private Button btnTaEmotMeddelande;
    }
}