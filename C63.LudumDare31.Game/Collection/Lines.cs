namespace C63.LudumDare31.Game.Collection
{
    public class Lines : System.Collections.Generic.List<Data.Line>
    {
        public event System.Action OnChanged;

        private Data.Line _Current;

        public Data.Line Current
        {
            get
            {
                return this._Current;
            }

            set
            {
                if(value == this._Current)
                {
                    return;
                }

                this._Current = value;

                if(this.OnChanged == null)
                {
                    return;
                }

                this.OnChanged();
            }
        }

        public Data.Line Find(Characters.Callers.Base caller)
        {
            foreach(var line in this)
            {
                if(line.Caller != caller)
                {
                    continue;
                }

                return line;
            }

            return null;
        }
    }
}
