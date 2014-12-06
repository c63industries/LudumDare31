namespace C63.LudumDare31.Game.Characters
{
    public abstract class Base
    {
        public Base()
        {
            this.Emotions = new Data.Emotions();
        }

        public Data.Emotions Emotions
        {
            get;
            private set;
        }
    }
}