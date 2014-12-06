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

        public Question(string dialog)
            : this(() => dialog)
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