namespace C63.LudumDare31.Game.Data
{
    public class Answer
    {
        public Answer(System.Func<string> dialog)
        {
            if (dialog == null)
            {
                throw new System.ArgumentNullException("dialog");
            }

            this.Dialog = dialog;
        }

        public Answer(string dialog)
            : this(() => dialog)
        {
        }

        public System.Func<string> Dialog
        {
            get;
            private set;
        }
    }
}