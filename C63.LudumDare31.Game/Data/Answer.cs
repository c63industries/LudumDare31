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

        public Answer(params string[] dialog)
            : this(() => System.String.Join(System.Environment.NewLine, dialog))
        {
        }

        public System.Func<string> Dialog
        {
            get;
            private set;
        }
    }
}