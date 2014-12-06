using System.Windows.Forms;

namespace C63.LudumDare31.Game
{
    static class Game
    {
        static Game()
        {
            Boss = new Characters.Boss();
            Callers = new System.Collections.Generic.List<Characters.Callers.Base>();
            Thread = new System.Threading.Thread(Loop);
        }

        static public Characters.Boss Boss
        {
            get;
            private set;
        }

        static public System.Collections.Generic.List<Characters.Callers.Base> Callers
        {
            get;
            private set;
        }

        static void Loop()
        {
            while (true)
            {
            }
        }

        static public System.Threading.Thread Thread
        {
            get;
            private set;
        }
    }
}