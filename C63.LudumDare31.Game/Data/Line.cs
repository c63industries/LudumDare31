namespace C63.LudumDare31.Game.Data
{
    public class Line
    {
        public Line(string text, System.Drawing.Color color)
        {
            this.Text = text;
        }

        public Line(string text)
            : this(text, System.Drawing.Color.AntiqueWhite)
        {
        }

        public Characters.Callers.Base Caller
        {
            get;
            private set;
        }

        public bool Connect(Characters.Callers.Base caller)
        {
            if(this.Caller != null)
            {
                return false;
            }

            this.Caller = caller;

            System.Console.WriteLine("{0} is calling on {1}.", caller, this);

            return true;
        }

        public bool Hold
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return System.String.Format("{0}", this.Text);
        }

        public string Text
        {
            get;
            private set;
        }
    }
}
