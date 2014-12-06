namespace C63.LudumDare31.Game.Data
{
    public class Question
    {
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