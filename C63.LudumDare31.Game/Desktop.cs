namespace C63.LudumDare31.Game
{
    public partial class Desktop : System.Windows.Forms.Form
    {
        public Desktop()
        {
            this.IsMdiContainer = true;

            InitializeComponent();

            this.Chat = new Chat
            {
                MdiParent = this,
            };

            this.Notepad = new Notepad
            {
                MdiParent = this,
            };

            this.Phone = new Phone
            {
                MdiParent = this,
            };

            this.PinkSlip = new PinkSlip
            {
                MdiParent = this,
            };

            this.Notepad.Show();
            this.Phone.Show();
           
        }

        public Chat Chat
        {
            get;
            private set;
        }

        public Notepad Notepad
        {
            get;
            private set;
        }

        public Phone Phone
        {
            get;
            private set;
        }

        public PinkSlip PinkSlip
        {
            get;
            private set;
        }
    }
}
