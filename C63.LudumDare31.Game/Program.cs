using System.Windows.Forms;

namespace C63.LudumDare31.Game

{
    static class Program
    {
        static Program()
        {
            Phone = new Phone();
            Chat = new Chat();
            PinkSlip = new PinkSlip();
            Notepad = new Notepad();

        }

        static void Main()
        {
            Application.Run();
        }

        static public Phone Phone
        {
            get;
            private set;
        }
        
        static public Chat Chat
        {
            get;
            private set;
        }
        
        static public PinkSlip PinkSlip
        {
            get;
            private set;
        }
        static public Notepad Notepad
        {
            get;
            private set;
        }

    }
}