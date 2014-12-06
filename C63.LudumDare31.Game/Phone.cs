namespace C63.LudumDare31.Game
{
    public partial class Phone : System.Windows.Forms.Form
    {
        private System.Collections.Generic.Dictionary<System.Windows.Forms.Button, System.Media.SoundPlayer> _Audio;

        public Phone()
        {
            InitializeComponent();

            this._Audio = new System.Collections.Generic.Dictionary<System.Windows.Forms.Button, System.Media.SoundPlayer>();

            this._Audio.Add(this.BTN0, new System.Media.SoundPlayer("Audio\\Buttons\\0.wav"));

            this.BTN0.MouseDown += this.MouseDown;
        }

        private void MouseDown(object sender, System.Windows.Forms.MouseEventArgs mouseEventArgs)
        {
            if (!(sender is System.Windows.Forms.Button))
            {
                return;
            }

            var button = (System.Windows.Forms.Button)sender;

            if (!this._Audio.ContainsKey(button))
            {
                return;
            }

            this._Audio[button].Play();
        }
    }
}
