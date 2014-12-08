namespace C63.LudumDare31.Game.Form.Buttons
{
    public class Number : System.Windows.Forms.Control
    {
        private new enum Events
        {
            Create,
            MouseDown,
            MouseUp,
        }

        public Number()
            : base()
        {
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForeColor = System.Drawing.Color.White;
            this.SoundPlayer = null;

            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.OnEvent(Events.Create);
        }

        private void OnEvent(Events e)
        {
            switch(e)
            {
                case Events.Create:
                case Events.MouseUp:

                    if (this.Image_MouseUp == null)
                    {
                        return;
                    }

                    this.BackColor = System.Drawing.Color.Transparent;
                    this.BackgroundImage = this.Image_MouseUp;

                    return;

                case Events.MouseDown:

                    if (this.Image_MouseDown == null)
                    {
                        return;
                    }

                    this.BackColor = System.Drawing.Color.Transparent;
                    this.BackgroundImage = this.Image_MouseDown;

                    return;
            }
        }

        [System.ComponentModel.Category("(Special)")]
        public System.String Audio_MouseDown
        {
            get;
            set;
        }

        [System.ComponentModel.Category("(Special)")]
        public System.Char Character
        {
            get;
            set;
        }

        [System.ComponentModel.Category("(Special)")]
        public System.Drawing.Image Image_MouseDown
        {
            get;
            set;
        }

        [System.ComponentModel.Category("(Special)")]
        public System.Drawing.Image Image_MouseUp
        {
            get;
            set;
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button != System.Windows.Forms.MouseButtons.Left)
            {
                return;
            }

            this.OnEvent(Events.MouseDown);

            if (this.SoundPlayer == null)
            {
                return;
            }

            this.SoundPlayer.Play();
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button != System.Windows.Forms.MouseButtons.Left)
            {
                return;
            }

            this.OnEvent(Events.MouseUp);
        }

        protected System.Media.SoundPlayer SoundPlayer
        {
            get;
            private set;
        }
    }
}
