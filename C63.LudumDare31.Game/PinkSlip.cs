namespace C63.LudumDare31.Game
{
    public partial class PinkSlip : System.Windows.Forms.Form
    {
        public PinkSlip()
        {
            InitializeComponent();

            this.btnReapply.Click += this.OnReapply;
        }

        private void OnReapply(object sender, System.EventArgs e)
        {
            Game.Start();
        }
    }
}
