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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDialog = new System.Windows.Forms.RichTextBox();
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtDialog, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlQuestions, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.84058F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.15942F));
<<<<<<< HEAD
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 308);
=======
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 345);
>>>>>>> aa02400a3e6d7d6b7bf8a74cb4252c07f1b3a243
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtDialog
            // 
            this.txtDialog.BackColor = System.Drawing.Color.White;
            this.txtDialog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDialog.DetectUrls = false;
            this.txtDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDialog.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDialog.Location = new System.Drawing.Point(3, 3);
            this.txtDialog.Name = "txtDialog";
<<<<<<< HEAD
            this.txtDialog.Size = new System.Drawing.Size(421, 113);
            this.txtDialog.TabIndex = 5;
=======
            this.txtDialog.ReadOnly = true;
            this.txtDialog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtDialog.Size = new System.Drawing.Size(656, 128);
            this.txtDialog.TabIndex = 1;
>>>>>>> aa02400a3e6d7d6b7bf8a74cb4252c07f1b3a243
            this.txtDialog.Tag = "";
            this.txtDialog.Text = "";
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestions.Location = new System.Drawing.Point(3, 122);
            this.pnlQuestions.Name = "pnlQuestions";
<<<<<<< HEAD
            this.pnlQuestions.Size = new System.Drawing.Size(460, 183);
=======
            this.pnlQuestions.Size = new System.Drawing.Size(656, 205);
>>>>>>> aa02400a3e6d7d6b7bf8a74cb4252c07f1b3a243
            this.pnlQuestions.TabIndex = 6;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(466, 308);
=======
            this.ClientSize = new System.Drawing.Size(662, 345);
            this.ControlBox = false;
>>>>>>> aa02400a3e6d7d6b7bf8a74cb4252c07f1b3a243
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Chat";
            this.ShowInTaskbar = false;
            this.Text = "Chat";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox txtDialog;
        private System.Windows.Forms.Panel pnlQuestions;
    }
}