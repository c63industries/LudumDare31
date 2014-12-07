using System.Linq;

namespace C63.LudumDare31.Game.Data
{
    public class Dialog
    {
        public System.Collections.Generic.Dictionary<Question, Answer> _Tree;

        public Dialog()
        {
            this._Tree = new System.Collections.Generic.Dictionary<Question, Answer>();
        }

        //

        public void Add(Question question, Answer answer)
        {
            if (question == null)
            {
                throw new System.ArgumentNullException("question");
            }

            if (answer == null)
            {
                throw new System.ArgumentNullException("answer");
            }

            question.OnAsk += this.OnAsk;

            this._Tree.Add(question, answer);
        }

        //

        public void Add(System.Func<string> question, Answer answer)
        {
            if (question == null)
            {
                throw new System.ArgumentNullException("question");
            }

            if (answer == null)
            {
                throw new System.ArgumentNullException("answer");
            }

            this.Add(new Question(question), answer);
        }

        public void Add(Question question, System.Func<string> answer)
        {
            if (question == null)
            {
                throw new System.ArgumentNullException("question");
            }

            if (answer == null)
            {
                throw new System.ArgumentNullException("answer");
            }

            this.Add(question, new Answer(answer));
        }

        public void Add(System.Func<string> question, System.Func<string> answer)
        {
            if (question == null)
            {
                throw new System.ArgumentNullException("question");
            }

            if (answer == null)
            {
                throw new System.ArgumentNullException("answer");
            }

            this.Add(new Question(question), new Answer(answer));
        }

        //

        public void Add(System.Func<string> question, string answer, System.Action action = null)
        {
            if (question == null)
            {
                throw new System.ArgumentNullException("question");
            }

            if (answer == null)
            {
                throw new System.ArgumentNullException("answer");
            }

            if (action == null)
            {
                this.Add(new Question(question), new Answer(answer));
            }
            else
            {
                this.Add(new Question(question), new Answer(() => { action(); return answer; }));
            }
        }

        public void Add(string question, System.Func<string> answer)
        {
            if (question == null)
            {
                throw new System.ArgumentNullException("question");
            }

            if (answer == null)
            {
                throw new System.ArgumentNullException("answer");
            }

            this.Add(new Question(question), new Answer(answer));
        }

        //

        public void Add(string question, Answer answer)
        {
            if (question == null)
            {
                throw new System.ArgumentNullException("question");
            }

            if (answer == null)
            {
                throw new System.ArgumentNullException("answer");
            }

            this.Add(new Question(question), answer);
        }

        public void Add(Question question, string answer, System.Action action = null)
        {
            if (question == null)
            {
                throw new System.ArgumentNullException("question");
            }

            if (answer == null)
            {
                throw new System.ArgumentNullException("answer");
            }

            if (action == null)
            {
                this.Add(question, new Answer(answer));
            }
            else
            {
                this.Add(question, new Answer(() => { action(); return answer; }));
            }
        }

        public void Add(string question, string answer, System.Action action = null)
        {
            if (question == null)
            {
                throw new System.ArgumentNullException("question");
            }

            if (answer == null)
            {
                throw new System.ArgumentNullException("answer");
            }

            if (action == null)
            {
                this.Add(new Question(question), new Answer(answer));
            }
            else
            {
                this.Add(new Question(question), new Answer(() => { action(); return answer; }));
            }
        }

        //

        private void OnAsk(Question question)
        {
            if(question == null)
            {
                return;
            }

            if(!this._Tree.ContainsKey(question))
            {
                return;
            }

            Answer answer = this._Tree[question];

            if (answer == null)
            {
                return;
            }

            Program.Chat.Add(answer.Dialog());
        }

        public Question[] Questions
        {
            get
            {
                return this._Tree.Keys.ToArray();
            }
        }
    }
}