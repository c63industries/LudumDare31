namespace C63.LudumDare31.Game

{
    static class Program
    {
        static Program()
        {
            Desktop = new Desktop();;
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

            System.Windows.Forms.Application.Run(Desktop);
        }
        
        static public Chat Chat
        {
            get
            {
                return Desktop.Chat;
            }
        }

        static public Desktop Desktop
        {
            get;
            private set;
        }
        
        static public Phone Phone
        {
            get
            {
                return Desktop.Phone;
            }
        }

        static public PinkSlip PinkSlip
        {
            get
            {
                return Desktop.PinkSlip;
            }
        }

        static public Notepad Notepad
        {
            get
            {
                return Desktop.Notepad;
            }
        }
    }
}