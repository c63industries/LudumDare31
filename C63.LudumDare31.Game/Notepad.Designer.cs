namespace C63.LudumDare31.Game
{
    partial class Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.NTPTXT1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NTPTXT1
            // 
            this.NTPTXT1.BackColor = System.Drawing.Color.White;
            this.NTPTXT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NTPTXT1.Location = new System.Drawing.Point(-1, -42);
            this.NTPTXT1.Multiline = true;
            this.NTPTXT1.Name = "NTPTXT1";
            this.NTPTXT1.Size = new System.Drawing.Size(391, 474);
            this.NTPTXT1.TabIndex = 0;
            this.NTPTXT1.Text = "Put your words here.";
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(382, 420);
            this.Controls.Add(this.NTPTXT1);
            this.Name = "Notepad";
            this.RightToLeftLayout = true;
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NTPTXT1;
    }
}