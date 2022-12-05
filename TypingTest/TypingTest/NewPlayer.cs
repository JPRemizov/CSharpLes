namespace TypingTest
{
    public class NewPlayer:MainWindow
    {
        public PlayerInfo curPlayer = new PlayerInfo();
        public override void Show()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            curPlayer.name = name;
            Program.curWindow = Program.MainWindow;
        }
    }
}
