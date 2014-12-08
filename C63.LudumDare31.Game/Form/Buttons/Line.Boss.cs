namespace C63.LudumDare31.Game.Form.Buttons
{
    public partial class Line
    {
        public class Boss : Line
        {
            public Boss()
                : base()
            {
            }

            protected override void OnCreateControl()
            {
                base.OnCreateControl();

                this.Data = new Data.Line.Boss(this);
            }
        }
    }
}
