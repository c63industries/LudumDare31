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

            Phone.Show();
        }

        static void Main()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write('\t');
            System.Console.WriteLine("Ludum Dare #31");
            System.Console.WriteLine();
            System.Console.Write('\t');
            System.Console.WriteLine("Made By");
            System.Console.WriteLine();
            System.Console.Write('\t');
            System.Console.Write('\t');
            System.Console.WriteLine("C63 Industries");
            System.Console.Write('\t');
            System.Console.Write('\t');
            System.Console.Write('\t');
            System.Console.WriteLine("& Friends");
            System.Console.WriteLine();
            System.Console.WriteLine();

            Game.Initialize();

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