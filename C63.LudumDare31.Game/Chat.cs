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
            this.txtDialog.Text = "";
        }

        public void Add(string text)
        {
            if (!System.String.IsNullOrEmpty(this.txtDialog.Text))
            {
                this.txtDialog.Text += System.Environment.NewLine;
            }

            this.txtDialog.Text += text;
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

            this.Add(linkLabel.Text);

            Data.Question question = _Questions[linkLabel];

            question.Ask();

            this.Update();
        }

        public void Update()
        {
            this._Questions.Clear();

            this.pnlQuestions.Controls.Clear();

            Data.Question[] questions = Program.Phone.Line.Caller.Dialog.Questions.OrderBy(q => q.Asked).ToArray();

            int y = 0;

            foreach(var question in questions)
            {
                var link = new System.Windows.Forms.LinkLabel
                {
                    Dock = System.Windows.Forms.DockStyle.Top,
                    Text = question.Dialog(),
                    Top = y,
                };

                link.Click += this.OnQuestion;

                y += link.Height;

                this.pnlQuestions.Controls.Add(link);

                this._Questions.Add(link, question);
            }
        }
    }
}
