namespace C63.LudumDare31.Game.Data
{
    public class Emotions
    {
        public event System.Action<sbyte> OnHappiness;
        public event System.Action<sbyte> OnPatience;

        private sbyte _Happiness;
        private sbyte _Patience;

        public sbyte Happiness
        {
            get
            {
                return this._Happiness;
            }

            set
            {
                if (value == this._Happiness)
                {
                    return;
                }

                this._Happiness = value;

                if (this.OnHappiness == null)
                {
                    return;
                }

                this.OnHappiness(this.Happiness);
            }
        }

        public sbyte Patience
        {
            get
            {
                return this._Patience;
            }

            set
            {
                if (value == this._Patience)
                {
                    return;
                }

                this._Patience = value;

                if (this.OnPatience == null)
                {
                    return;
                }

                this.OnPatience(this.Patience);
            }
        }
    }
}
