namespace C63.LudumDare31.Game.Data
{
    public partial class Line
    {
        public class Boss : Line
        {
            public Boss(Form.Buttons.Line.Boss button)
                : base(button)
            {
            }

            public override bool Call(Characters.Callers.Base caller)
            {
                this.Holding = false;

                if (this.Caller != null)
                {
                    return false;
                }

                if (caller != Game.Boss)
                {
                    return false;
                }

                this.Caller = caller;

                System.Console.WriteLine("{0} is calling on {1}.", caller, this);

                return true;
            }
        }
    }
}
