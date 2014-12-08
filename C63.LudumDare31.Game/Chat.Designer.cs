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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.spltChat = new System.Windows.Forms.SplitContainer();
            this.txtDialog = new System.Windows.Forms.RichTextBox();
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.spltChat.Panel1.SuspendLayout();
            this.spltChat.Panel2.SuspendLayout();
            this.spltChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltChat
            // 
            this.spltChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spltChat.Location = new System.Drawing.Point(12, 12);
            this.spltChat.Name = "spltChat";
            this.spltChat.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltChat.Panel1
            // 
            this.spltChat.Panel1.Controls.Add(this.txtDialog);
            // 
            // spltChat.Panel2
            // 
            this.spltChat.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.spltChat.Panel2.Controls.Add(this.pnlQuestions);
            this.spltChat.Size = new System.Drawing.Size(654, 406);
            this.spltChat.SplitterDistance = 304;
            this.spltChat.TabIndex = 0;
            // 
            // txtDialog
            // 
            this.txtDialog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDialog.Location = new System.Drawing.Point(0, 0);
            this.txtDialog.Name = "txtDialog";
            this.txtDialog.Size = new System.Drawing.Size(654, 304);
            this.txtDialog.TabIndex = 0;
            this.txtDialog.Text = "";
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.AutoScroll = true;
            this.pnlQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestions.ForeColor = System.Drawing.Color.Transparent;
            this.pnlQuestions.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestions.Name = "pnlQuestions";
            this.pnlQuestions.Size = new System.Drawing.Size(654, 98);
            this.pnlQuestions.TabIndex = 0;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 430);
            this.ControlBox = false;
            this.Controls.Add(this.spltChat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Chat";
            this.ShowInTaskbar = false;
            this.Text = "ICU";
            this.spltChat.Panel1.ResumeLayout(false);
            this.spltChat.Panel2.ResumeLayout(false);
            this.spltChat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.SplitContainer spltChat;
        private System.Windows.Forms.RichTextBox txtDialog;
        private System.Windows.Forms.Panel pnlQuestions;
    }
}