using System.Linq;

namespace C63.LudumDare31.Game.Form.Buttons
{
    public class Line : System.Windows.Forms.Control
    {
        public new enum Events
        {
            Create,
            Disconnected,
            Connected,
            Incomming,
        }

        public Line()
            : base()
        {
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
        }

        public Data.Line Data
        {
            get;
            private set;
        }

        [System.ComponentModel.Category("(Special)")]
        public System.Drawing.Image Image_Connected
        {
            get;
            set;
        }

        [System.ComponentModel.Category("(Special)")]
        public System.Drawing.Image Image_Disconnected
        {
            get;
            set;
        }

        [System.ComponentModel.Category("(Special)")]
        public System.Drawing.Image Image_Incomming
        {
            get;
            set;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.OnEvent(Events.Create);

            this.Data = new Data.Line(this);

            Game.OnCycle += OnCycle;
        }

        protected virtual void OnCycle(ulong cycles)
        {
            if (this.Data.Caller != null)
            {
                if (this.Data.Caller.Connected)
                {
                    return;
                }

                this.OnEvent(Events.Incomming);

                return;
            }

            if (Game.Random.Next(0, 10) > 0)
            {
                return;
            }

            var callers = Game.Callers.Where(c => Program.Phone.Lines.Where(l => l.Caller == c).Count() < 1).ToArray();

            if (!callers.Any())
            {
                return;
            }

            int index = Game.Random.Next(callers.Length);

            this.Data.Call(callers[index]);
        }

        public void OnEvent(Events e)
        {
            switch (e)
            {
                case Events.Connected:

                    if (this.Image_Connected == null)
                    {
                        this.BackColor = System.Drawing.Color.Gray;
                        return;
                    }

                    this.BackColor = System.Drawing.Color.Transparent;
                    this.BackgroundImage = this.Image_Connected;

                    return;

                case Events.Create:
                case Events.Disconnected:

                    if (this.Image_Disconnected == null)
                    {
                        this.BackColor = System.Drawing.Color.DarkGray;
                        return;
                    }

                    this.BackColor = System.Drawing.Color.Transparent;
                    this.BackgroundImage = this.Image_Disconnected;

                    return;

                case Events.Incomming:

                    if (this.Image_Incomming == null)
                    {
                        this.BackColor = System.Drawing.Color.White;
                        return;
                    }

                    this.BackColor = System.Drawing.Color.Transparent;
                    this.BackgroundImage = this.Image_Incomming;

                    return;
            }
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button != System.Windows.Forms.MouseButtons.Left)
            {
                return;
            }

            if (this.Data.Caller == null)
            {
                return;
            }

            if(this.Data.Connected)
            {
                this.Data.Disconnect();
            }
            else
            {
                this.Data.Connect();
            }
        }
    }
}
