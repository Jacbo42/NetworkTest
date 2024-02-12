namespace WinFormsApp_Övning_5_4_Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIPadress = new System.Windows.Forms.TextBox();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.btnUpp = new System.Windows.Forms.Button();
            this.btnVänster = new System.Windows.Forms.Button();
            this.btnNer = new System.Windows.Forms.Button();
            this.btnHöger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns IP-adress";
            // 
            // tbxIPadress
            // 
            this.tbxIPadress.Location = new System.Drawing.Point(204, 31);
            this.tbxIPadress.Name = "tbxIPadress";
            this.tbxIPadress.Size = new System.Drawing.Size(150, 31);
            this.tbxIPadress.TabIndex = 1;
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(360, 28);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(112, 34);
            this.btnAnslut.TabIndex = 2;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // btnUpp
            // 
            this.btnUpp.Enabled = false;
            this.btnUpp.Location = new System.Drawing.Point(204, 106);
            this.btnUpp.Name = "btnUpp";
            this.btnUpp.Size = new System.Drawing.Size(112, 34);
            this.btnUpp.TabIndex = 4;
            this.btnUpp.Text = "Upp";
            this.btnUpp.UseVisualStyleBackColor = true;
            this.btnUpp.Click += new System.EventHandler(this.btnUpp_Click);
            // 
            // btnVänster
            // 
            this.btnVänster.Enabled = false;
            this.btnVänster.Location = new System.Drawing.Point(86, 146);
            this.btnVänster.Name = "btnVänster";
            this.btnVänster.Size = new System.Drawing.Size(112, 34);
            this.btnVänster.TabIndex = 5;
            this.btnVänster.Text = "Vänster";
            this.btnVänster.UseVisualStyleBackColor = true;
            this.btnVänster.Click += new System.EventHandler(this.btnVänster_Click);
            // 
            // btnNer
            // 
            this.btnNer.Enabled = false;
            this.btnNer.Location = new System.Drawing.Point(204, 186);
            this.btnNer.Name = "btnNer";
            this.btnNer.Size = new System.Drawing.Size(112, 34);
            this.btnNer.TabIndex = 6;
            this.btnNer.Text = "Ner";
            this.btnNer.UseVisualStyleBackColor = true;
            this.btnNer.Click += new System.EventHandler(this.btnNer_Click);
            // 
            // btnHöger
            // 
            this.btnHöger.Enabled = false;
            this.btnHöger.Location = new System.Drawing.Point(322, 146);
            this.btnHöger.Name = "btnHöger";
            this.btnHöger.Size = new System.Drawing.Size(112, 34);
            this.btnHöger.TabIndex = 7;
            this.btnHöger.Text = "Höger";
            this.btnHöger.UseVisualStyleBackColor = true;
            this.btnHöger.Click += new System.EventHandler(this.btnHöger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 249);
            this.Controls.Add(this.btnHöger);
            this.Controls.Add(this.btnNer);
            this.Controls.Add(this.btnVänster);
            this.Controls.Add(this.btnUpp);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.tbxIPadress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbxIPadress;
        private Button btnAnslut;
        private Button btnUpp;
        private Button btnVänster;
        private Button btnNer;
        private Button btnHöger;
    }
}