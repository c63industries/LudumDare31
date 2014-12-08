namespace C63.LudumDare31.Game
{
    partial class PinkSlip
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
            this.PINKSLIP1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PINKSLIP1
            // 
            this.PINKSLIP1.BackColor = System.Drawing.Color.LavenderBlush;
            this.PINKSLIP1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINKSLIP1.Location = new System.Drawing.Point(2, 4);
            this.PINKSLIP1.Name = "PINKSLIP1";
            this.PINKSLIP1.Size = new System.Drawing.Size(304, 261);
            this.PINKSLIP1.TabIndex = 0;
            this.PINKSLIP1.Text = "                                  Your Fired\n\n__  Warning (At Risk for Terminatio" +
    "n)\n\n\n__  Notice of Termination\n\n";
            // 
            // PinkSlip
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 267);
            this.Controls.Add(this.PINKSLIP1);
            this.Name = "PinkSlip";
            this.Text = "Pink Slip";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.RichTextBox PINKSLIP1;

    }
}