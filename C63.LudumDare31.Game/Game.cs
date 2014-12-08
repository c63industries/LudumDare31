using System.Linq;

namespace C63.LudumDare31.Game
{
    static class Game
    {
        static public event System.Action<ulong> OnCycle;

        static Game()
        {
            Boss = new Characters.Boss();
            Callers = new System.Collections.Generic.List<Characters.Callers.Base>();
            Random = new System.Random();
            Thread = new System.Threading.Thread(Loop)
            {
                IsBackground = true,
                Name = "Game Loop",
                Priority = System.Threading.ThreadPriority.Lowest,
            };
        }

        static public Characters.Boss Boss
        {
            get;
            private set;
        }

        static public ulong Cycles
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
            Callers.Add(new Characters.Callers.Welcome());
            Callers.Add(new Characters.Callers.IntroDuckTion());
            Callers.Add(new Characters.Callers.SantaIntro());

            //Callers.Add(new Characters.Callers.FAA());
            Callers.Add(new Characters.Callers.Four20());
            Callers.Add(new Characters.Callers.Grandma());
            Callers.Add(new Characters.Callers.LaborRep());
            //Callers.Add(new Characters.Callers.RoboCaller());

            Thread.Start();
        }

        static void Loop()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);

                Cycles++;

                if(OnCycle == null)
                {
                    continue;
                }

                OnCycle(Cycles);
            }
        }

        static public System.Random Random
        {
            get;
            private set;
        }

        static public System.Threading.Thread Thread
        {
            get;
            private set;
        }
    }
}