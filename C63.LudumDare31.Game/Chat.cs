using System.Linq;

namespace C63.LudumDare31.Game
{
    public partial class Chat : System.Windows.Forms.Form
    {
        private System.Collections.Generic.Dictionary<System.Windows.Forms.LinkLabel, Data.Question> _Questions;

        public Chat()
        {
            InitializeComponent();

            this._Questions = new System.Collections.Generic.Dictionary<System.Windows.Forms.LinkLabel, Data.Question>();
        }

        public void Clear()
        {
            this.txtDialog.Text = System.String.Empty;
        }

        public void Add(string text, System.Drawing.Color color)
        {
            if(this.txtDialog.TextLength > 0)
            {
                this.txtDialog.AppendText(System.Environment.NewLine);
            }

            this.txtDialog.SelectionColor = color;
            this.txtDialog.AppendText(text);

            Extensions.ScrollToBottom(this.txtDialog);
        }

        private void OnQuestion(object sender, System.EventArgs e)
        {
            if(!(sender is System.Windows.Forms.LinkLabel))
            {
                return;
            }

            var linkLabel = (System.Windows.Forms.LinkLabel)sender;

            if(!_Questions.ContainsKey(linkLabel))
            {
                return;
            }

            this.Add(linkLabel.Text, System.Drawing.Color.Red);

            Data.Question question = _Questions[linkLabel];

            question.Ask();
        }

        public new void Update()
        {
            this._Questions.Clear();

            this.pnlQuestions.Controls.Clear();

            if(Program.Phone.Lines.Current == null)
            {
                return;
            }

            Data.Question[] questions = Program.Phone.Lines.Current.Caller.Dialog.Questions.OrderByDescending(q => q.Asked).ToArray();

            foreach(var question in questions)
            {
                var link = new System.Windows.Forms.LinkLabel
                {
                    Dock = System.Windows.Forms.DockStyle.Top,
                    LinkColor = question.Asked > 0 ? System.Drawing.Color.DarkGray : System.Drawing.Color.Black,
                    Text = question.Dialog,
                };

                link.Click += this.OnQuestion;

                this.pnlQuestions.Controls.Add(link);

                this._Questions.Add(link, question);
            }
        }
    }
}
