using System.Text;

namespace TypingTest
{
    internal class Program
    {
        public static MainWindow MainWindow = new MainWindow();
        public static RecordTable recordTable = new RecordTable();
        public static NewPlayer NewPlayer = new NewPlayer();
        public static MainWindow curWindow = NewPlayer;
        public static PlayerInfo playerInfo = new PlayerInfo();
        public static bool exit = false;
        static void Main(string[] args)
        {
            while (!exit)
            {
                curWindow.Show();
            }
        }
    }
}