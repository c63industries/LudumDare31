namespace C63.LudumDare31.Game.Characters.Callers
{
    public abstract class Base : Characters.Base
    {
        public Base()
            : base()
        {
            this.Dialog = new Data.Dialog();
        }

        public Data.Dialog Dialog
        {
            get;
            private set;
        }
    }
}
