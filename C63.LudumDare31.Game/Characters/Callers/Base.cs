namespace C63.LudumDare31.Game.Characters.Callers
{
    public abstract class Base : Characters.Base
    {
        public event System.Action<char> OnButton;
        public event System.Action OnConnect;
        public event System.Action OnDiconnect;

        public Base()
            : base()
        {
            this.Dialog = new Data.Dialog();
        }

        public void Button(char button)
        {
            if (this.OnButton == null)
            {
                return;
            }

            this.OnButton(button);
        }

        public byte Calls
        {
            get;
            private set;
        }

        public void Connect()
        {
            this.Calls++;
            this.Connected = true;

            if (this.OnConnect == null)
            {
                return;
            }

            this.OnConnect();
        }

        public bool Connected
        {
            get;
            private set;
        }

        public Data.Dialog Dialog
        {
            get;
            private set;
        }

        public void Disconnect()
        {
            this.Connected = false;

            if (this.OnDiconnect == null)
            {
                return;
            }

            this.OnDiconnect();
        }
    }
}
