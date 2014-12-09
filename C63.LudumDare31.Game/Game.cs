using System.Linq;

namespace C63.LudumDare31.Game
{
    static class Game
    {
        static public event System.Action<ulong> OnCycle;

        static Game()
        {
            Callers = new System.Collections.Generic.List<Characters.Callers.Base>();
            Random = new System.Random();
            Thread = new System.Threading.Thread(Loop)
            {
                IsBackground = true,
                Name = "Game Loop",
                Priority = System.Threading.ThreadPriority.Lowest,
            };
        }

        static public Characters.Callers.Santa Boss
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

        static public void End()
        {
            Program.Chat.Hide();
            Program.Notepad.Hide();
            Program.Phone.Hide();

            Program.PinkSlip.Show();
        }

        static public void Initialize()
        {
            Start();

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

        static public void Start()
        {
            Callers.Clear();

            foreach (var line in Program.Phone.Lines)
            {
                line.Disconnect();
            }

            Boss = new Characters.Callers.Santa();

            Program.Chat.Hide();
            Program.PinkSlip.Hide(); 
            
            Program.Notepad.Show();
            Program.Phone.Show();

            Callers.Add(new Characters.Callers.Welcome());
        }

        static public System.Threading.Thread Thread
        {
            get;
            private set;
        }
    }
}