using System.Linq;

namespace C63.LudumDare31.Game
{
    public partial class Phone : System.Windows.Forms.Form
    {
        private System.Collections.Generic.Dictionary<System.Windows.Forms.Button, System.Media.SoundPlayer> _Audio;

        public Phone()
        {
            this.Lines = new Collection.Lines();

            InitializeComponent();

            this._Audio = new System.Collections.Generic.Dictionary<System.Windows.Forms.Button, System.Media.SoundPlayer>();

            this._Audio.Add(this.BTN0, new System.Media.SoundPlayer("Audio\\Buttons\\0.wav"));
            this._Audio.Add(this.BTN1, new System.Media.SoundPlayer("Audio\\Buttons\\1.wav"));
            this._Audio.Add(this.BTN2, new System.Media.SoundPlayer("Audio\\Buttons\\2.wav"));
            this._Audio.Add(this.BTN3, new System.Media.SoundPlayer("Audio\\Buttons\\3.wav"));
            this._Audio.Add(this.BTN4, new System.Media.SoundPlayer("Audio\\Buttons\\4.wav"));
            this._Audio.Add(this.BTN5, new System.Media.SoundPlayer("Audio\\Buttons\\5.wav"));
            this._Audio.Add(this.BTN6, new System.Media.SoundPlayer("Audio\\Buttons\\6.wav"));
            this._Audio.Add(this.BTN7, new System.Media.SoundPlayer("Audio\\Buttons\\7.wav"));
            this._Audio.Add(this.BTN8, new System.Media.SoundPlayer("Audio\\Buttons\\8.wav"));
            this._Audio.Add(this.BTN9, new System.Media.SoundPlayer("Audio\\Buttons\\9.wav"));
            this._Audio.Add(this.BTNAST, new System.Media.SoundPlayer("Audio\\Buttons\\star.wav"));
            this._Audio.Add(this.BTNPOU, new System.Media.SoundPlayer("Audio\\Buttons\\pound.wav"));

            foreach(var button in this._Audio.Keys)
            {
                button.MouseDown += this.OnButton;
            }
        }

        public Collection.Lines Lines
        {
            get;
            private set;
        }

        private void OnButton(object sender, System.Windows.Forms.MouseEventArgs mouseEventArgs)
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
