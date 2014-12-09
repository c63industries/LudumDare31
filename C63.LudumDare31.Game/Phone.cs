using System.Linq;

namespace C63.LudumDare31.Game
{
    public partial class Phone : System.Windows.Forms.Form
    {
        private System.Collections.Generic.Dictionary<Form.Buttons.Number, System.Media.SoundPlayer> _Audio;

        public Phone()
        {
            this.Lines = new Collection.Lines();

            InitializeComponent();

            this.btnHangUp.Click += this.OnClick;
            this.btnHold.Click += this.OnClick;
            this.btnTransfer.Click += this.OnClick;

            this._Audio = new System.Collections.Generic.Dictionary<Form.Buttons.Number,System.Media.SoundPlayer>();

            this._Audio.Add(this.btnZero, new System.Media.SoundPlayer(Properties.Resources.sndButton0));
            this._Audio.Add(this.btnOne, new System.Media.SoundPlayer(Properties.Resources.sndButton1));
            this._Audio.Add(this.btnTwo, new System.Media.SoundPlayer(Properties.Resources.sndButton2));
            this._Audio.Add(this.btnThree, new System.Media.SoundPlayer(Properties.Resources.sndButton3));
            this._Audio.Add(this.btnFour, new System.Media.SoundPlayer(Properties.Resources.sndButton4));
            this._Audio.Add(this.btnFive, new System.Media.SoundPlayer(Properties.Resources.sndButton5));
            this._Audio.Add(this.btnSix, new System.Media.SoundPlayer(Properties.Resources.sndButton6));
            this._Audio.Add(this.btnSeven, new System.Media.SoundPlayer(Properties.Resources.sndButton7));
            this._Audio.Add(this.btnEight, new System.Media.SoundPlayer(Properties.Resources.sndButton8));
            this._Audio.Add(this.btnNine, new System.Media.SoundPlayer(Properties.Resources.sndButton9));
            this._Audio.Add(this.btnStar, new System.Media.SoundPlayer(Properties.Resources.sndButtonStar));
            this._Audio.Add(this.btnPound, new System.Media.SoundPlayer(Properties.Resources.sndButtonPound));

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
            if (!(sender is Form.Buttons.Number))
            {
                return;
            }

            var button = (Form.Buttons.Number)sender;

            if (!this._Audio.ContainsKey(button))
            {
                return;
            }

            this._Audio[button].Play();
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            if (this.Lines.Current == null)
            {
                return;
            }
            else if(sender == this.btnHangUp)
            {
                this.Lines.Current.Disconnect();
            }
            else if(sender == this.btnHold)
            {
                this.Lines.Current.Hold();
            }
            else if(sender == this.btnTransfer)
            {
                this.Lines.Current.Transfer();
            }
        }
    }
}
