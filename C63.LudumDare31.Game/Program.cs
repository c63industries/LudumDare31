using System.Windows.Forms;

namespace C63.LudumDare31.Game
{
    static class Program
    {
        static Program()
        {
            Phone = new Phone();
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
    }
}