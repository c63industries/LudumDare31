using System.Linq;

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

        static public void Initialize()
        {
            Callers.Add(new Characters.Callers.Example());

            Thread.Start();
        }

        static void Loop()
        {
            while (true)
            {
                var line = Program.Phone.Lines.Where(l => l.Caller == null).FirstOrDefault();

                if(line == null)
                {
                    continue;
                }

                var callers = Callers.Where(c => Program.Phone.Lines.Where(l => l.Caller == c).Count() < 1).ToArray();

                if (!callers.Any())
                {
                    continue;
                }

                line.Connect(callers.First());
            }
        }

        static public System.Threading.Thread Thread
        {
            get;
            private set;
        }
    }
}