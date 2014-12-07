namespace C63.LudumDare31.Game.Data
{
    public class Question
    {
        public event System.Action<Question> OnAsk;

        public Question(System.Func<string> dialog)
        {
            if (dialog == null)
            {
                throw new System.ArgumentNullException("dialog");
            }

            this.Dialog = dialog;
        }

        public Question(params string[] dialog)
            : this(() => System.String.Join(System.Environment.NewLine, dialog))
        {
        }

        public void Ask()
        {
            this.Asked++;

            if(this.OnAsk == null)
            {
                return;
            }

            this.OnAsk(this);
        }

        public byte Asked
        {
            get;
            set;
        }

        public System.Func<string> Dialog
        {
            get;
            private set;
        }
    }
}