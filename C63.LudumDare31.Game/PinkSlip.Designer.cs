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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinkSlip));
            this.PINKSLIP1 = new System.Windows.Forms.RichTextBox();
            this.rpplybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PINKSLIP1
            // 
            this.PINKSLIP1.BackColor = System.Drawing.Color.HotPink;
            this.PINKSLIP1.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINKSLIP1.Location = new System.Drawing.Point(-1, 0);
            this.PINKSLIP1.Name = "PINKSLIP1";
            this.PINKSLIP1.Size = new System.Drawing.Size(378, 369);
            this.PINKSLIP1.TabIndex = 0;
            this.PINKSLIP1.Text = resources.GetString("PINKSLIP1.Text");
            this.PINKSLIP1.TextChanged += new System.EventHandler(this.PINKSLIP1_TextChanged);
            // 
            // rpplybtn
            // 
            this.rpplybtn.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpplybtn.Location = new System.Drawing.Point(122, 301);
            this.rpplybtn.Name = "rpplybtn";
            this.rpplybtn.Size = new System.Drawing.Size(118, 46);
            this.rpplybtn.TabIndex = 1;
            this.rpplybtn.Text = "Reapply?";
            this.rpplybtn.UseVisualStyleBackColor = true;
            this.rpplybtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PinkSlip
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(376, 366);
            this.Controls.Add(this.rpplybtn);
            this.Controls.Add(this.PINKSLIP1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PinkSlip";
            this.Text = "Pink Slip";
            this.Load += new System.EventHandler(this.PinkSlip_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.RichTextBox PINKSLIP1;
        private System.Windows.Forms.Button rpplybtn;

    }
}