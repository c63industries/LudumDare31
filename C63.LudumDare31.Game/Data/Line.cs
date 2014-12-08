namespace C63.LudumDare31.Game.Data
{
    public class Line
    {
        public Line(Form.Buttons.Line button)
        {
            this.Button = button;

            Program.Phone.Lines.OnChanged += this.OnLineChanged;
        }

        public Form.Buttons.Line Button
        {
            get;
            private set;
        }

        public bool Call(Characters.Callers.Base caller)
        {
            this.Holding = false;

            if (this.Caller != null)
            {
                return false;
            }

            this.Caller = caller;

            System.Console.WriteLine("{0} is calling on {1}.", caller, this);

            return true;
        }

        public Characters.Callers.Base Caller
        {
            get;
            private set;
        }

        public void Connect()
        {
            this.Holding = false;

            if (this.Caller == null)
            {
                return;
            }

            Program.Phone.Lines.Current = this;

            this.Connected = true;

            this.Caller.Connect();

            this.Button.OnEvent(Form.Buttons.Line.Events.Connected);

            System.Console.WriteLine("{0} is connected on {1}.", this.Caller, this);
        }

        public bool Connected
        {
            get;
            private set;
        }

        public void Disconnect()
        {
            this.Connected = false;
            this.Holding = false;

            if (this.Caller == null)
            {
                return;
            }

            this.Caller.Disconnect(this.Holding);

            this.Button.OnEvent(Form.Buttons.Line.Events.Disconnected);

            System.Console.WriteLine("{0} has been disconnected from {1}.", this.Caller, this);

            this.Caller = null;
        }

        public void Hold()
        {
            this.Connected = false;

            if (this.Caller == null)
            {
                return;
            }

            this.Holding = true;

            this.Caller.Disconnect(this.Holding);

            this.Button.OnEvent(Form.Buttons.Line.Events.Incomming);

            System.Console.WriteLine("{0} has been placed on hold on {1}.", this.Caller, this);
        }

        public bool Holding
        {
            get;
            private set;
        }

        public void OnLineChanged()
        {
            if (Program.Phone.Lines.Current == this)
            {
            }
            else if (this.Caller == null)
            {
                this.Disconnect();
            }
            else
            {
                this.Hold();
            }
        }

        public void Transfer()
        {
            this.Connected = false;
            this.Holding = false;

            if (this.Caller == null)
            {
                return;
            }

            this.Caller.Transfer();

            this.Button.OnEvent(Form.Buttons.Line.Events.Incomming);

            System.Console.WriteLine("{0} has been transfered.", this.Caller, this);
        }
    }
}