using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTest
{
    public class RecordTable:MainWindow
    {

        public override void Show()
        {
            Console.Clear();
            Console.WriteLine("Имя\t\tСимволы в минуту\tСимволы в секунду");
            foreach(var item in Program.playerInfo.players)
            {
                Console.WriteLine($"{item.name}\t\t\t{item.SPM}\t\t\t{item.SPS}");

            }
            Console.WriteLine("-------------\nНажмите Enter для выхода...");
            Console.ReadLine();
            Program.curWindow = Program.NewPlayer;
            Console.Clear();
        }
    }
}
