namespace C63.LudumDare31.Game.Characters.Callers
{
    public abstract class Base : Characters.Base
    {
        public event System.Action<char> OnButton;
        public event System.Action OnConnect;
        public event System.Action<bool> OnDisconnect;

        public Base()
            : base()
        {
            this.Dialog = new Data.Dialog();
            this.Number = "(???) ???-????";
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

        public virtual void Connect()
        {
            this.Calls++;
            this.Connected = true;

            Program.Chat.Clear();
            Program.Chat.Show();
            Program.Chat.Update();

            System.Console.WriteLine("{0} is connected.", this);

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

        public virtual void Disconnect(bool hold)
        {
            this.Connected = false;

            Program.Chat.Clear();
            Program.Chat.Hide();

            System.Console.WriteLine("{0} is {1}.", this, hold ? "holding" : "disconnected");

            if (this.OnDisconnect == null)
            {
                return;
            }

            this.OnDisconnect(hold);
        }

        public string Number
        {
            get;
            protected set;
        }

        public override string ToString()
        {
            return "Caller";
        }
    }
}
