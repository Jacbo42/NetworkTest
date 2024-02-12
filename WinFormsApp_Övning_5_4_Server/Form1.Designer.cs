namespace WinFormsApp_Övning_5_4_Server
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
            this.pbxToteninsel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxToteninsel)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxToteninsel
            // 
            this.pbxToteninsel.Image = global::WinFormsApp_Övning_5_4_Server.Properties.Resources.Arnold_Böcklin___Die_Toteninsel_III__Alte_Nationalgalerie__Berlin_;
            this.pbxToteninsel.Location = new System.Drawing.Point(265, 149);
            this.pbxToteninsel.Name = "pbxToteninsel";
            this.pbxToteninsel.Size = new System.Drawing.Size(235, 125);
            this.pbxToteninsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxToteninsel.TabIndex = 0;
            this.pbxToteninsel.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxToteninsel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxToteninsel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbxToteninsel;
    }
}