namespace C63.LudumDare31.Game
{
    partial class Chat
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ANS1 = new System.Windows.Forms.Button();
            this.ANS2 = new System.Windows.Forms.Button();
            this.ANS3 = new System.Windows.Forms.Button();
            this.ANS4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Dia1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ANS1
            // 
            this.ANS1.Location = new System.Drawing.Point(3, 138);
            this.ANS1.Name = "ANS1";
            this.ANS1.Size = new System.Drawing.Size(259, 26);
            this.ANS1.TabIndex = 1;
            this.ANS1.Text = "Snowman: Why u so squatchy?";
            this.ANS1.UseVisualStyleBackColor = true;
            this.ANS1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ANS2
            // 
            this.ANS2.Location = new System.Drawing.Point(3, 187);
            this.ANS2.Name = "ANS2";
            this.ANS2.Size = new System.Drawing.Size(256, 29);
            this.ANS2.TabIndex = 2;
            this.ANS2.Text = "Snowman: I\'m sure everyone will pay you back.";
            this.ANS2.UseVisualStyleBackColor = true;
            this.ANS2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ANS3
            // 
            this.ANS3.Location = new System.Drawing.Point(3, 237);
            this.ANS3.Name = "ANS3";
            this.ANS3.Size = new System.Drawing.Size(262, 36);
            this.ANS3.TabIndex = 3;
            this.ANS3.Text = "Snowman: Santa is to hungover to deal with this.";
            this.ANS3.UseVisualStyleBackColor = true;
            // 
            // ANS4
            // 
            this.ANS4.Location = new System.Drawing.Point(3, 299);
            this.ANS4.Name = "ANS4";
            this.ANS4.Size = new System.Drawing.Size(259, 26);
            this.ANS4.TabIndex = 4;
            this.ANS4.Text = "Snowman: I\'ll make sure he knows.";
            this.ANS4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ANS4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ANS1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ANS3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ANS2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Dia1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.36957F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.63043F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 345);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Dia1
            // 
            this.Dia1.ForeColor = System.Drawing.Color.Olive;
            this.Dia1.Location = new System.Drawing.Point(3, 3);
            this.Dia1.Name = "Dia1";
            this.Dia1.Size = new System.Drawing.Size(419, 129);
            this.Dia1.TabIndex = 5;
            this.Dia1.Tag = "";
            this.Dia1.Text = "Lady Ducky: I\'m a duck quack quack quack. I need a raise for bread quack quack. I" +
    " spent all my bread money on sharpies for the break room quack. Nobody even paid" +
    " me back quack.";
            this.Dia1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button ANS1;
        private System.Windows.Forms.Button ANS2;
        private System.Windows.Forms.Button ANS3;
        private System.Windows.Forms.Button ANS4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox Dia1;
    }
}