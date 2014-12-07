namespace C63.LudumDare31.Game.Data
{
    public class Question
    {
        public event System.Action<Question> OnAsk;

        public Question(params string[] dialog)
        {
            if (dialog == null)
            {
                throw new System.ArgumentNullException("dialog");
            }

            this.Dialog = System.String.Join(System.Environment.NewLine, dialog);
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

        public string Dialog
        {
            get;
            private set;
        }
    }
}