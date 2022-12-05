using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TypingTest
{
    public class MainWindow
    {
        private static StringBuilder correctText = new StringBuilder();
        private static bool exc = false;
        static Thread thread = new Thread(_ =>
        {
            Stopwatch stopWatch = new Stopwatch();
            while (true)
            {
                if (start && Program.curWindow == Program.MainWindow)
                {
                    stopWatch.Start();
                    Console.ResetColor();
                    Console.SetCursorPosition(0, maxLines + 1);
                    Console.Write("Оставшееся время: " + seconds + " ");
                    if (correctText.Length == text.Length - 2 || seconds <= 0)
                    {
                        stopWatch.Stop();
                        TimeSpan ts = stopWatch.Elapsed;
                        Program.NewPlayer.curPlayer.SPS = correctText.Length / (float)ts.Seconds;
                        Program.NewPlayer.curPlayer.SPM = Program.NewPlayer.curPlayer.SPS * 60;
                        Program.playerInfo.players.Add(new PlayerInfo(Program.NewPlayer.curPlayer));
                        Serializer.Serialize(Program.playerInfo.players);
                        stopWatch.Reset();
                        Console.ResetColor();
                        Program.curWindow = Program.recordTable;
                        exc = true;
                        Console.SetCursorPosition(0, maxLines + 2);
                        Console.WriteLine("Нажмите любую клавишу...");
                    }
                    Thread.Sleep(1000);
                    seconds--;
                }
            }
            thread.Interrupt();
        });
        private static string text;
        private static int posX = 0, posY = 0, maxLines = 1, totalChar = 0, seconds = 20;
        private static bool wasExcecut = false;
        private static bool start = false;
        public static void Clear()
        {
            Console.Clear();
        }
        public virtual void Show()
        {
            Clear();
            Console.SetCursorPosition(0, 0);
            if (!wasExcecut)
            {
                text = Serializer.LoadText();
                if (string.IsNullOrEmpty(text))
                {
                    Console.WriteLine("Необходимо заполнить файл \"TypingText.txt\", созданный рядом с программой");
                    Console.WriteLine("Нажмите любую клавишу для продожения...");
                    Console.ReadKey(true);
                }
                else
                {
                    wasExcecut = true;
                }
            }
            else
            {
              
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text[i]);
                    if ((i + 1) % Console.WindowWidth == 0)
                    {
                        maxLines++;
                    }
                }
                while (seconds > 0)
                {
                    ConsoleKeyInfo playerKey = Console.ReadKey(true);
                    if (posX < Console.WindowWidth)
                    {
                        Console.SetCursorPosition(posX, posY);
                    }
                    else
                    {
                        posY++;
                        posX = 0;
                    }
                    if (playerKey.KeyChar == text[totalChar])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("");
                        Console.Write(playerKey.KeyChar);
                        correctText.Append(playerKey.KeyChar);
                        if (!start)
                        {
                            start = true;
                            thread.Start();
                        }
                        posX++;
                        totalChar++;
                    }
                    if (exc == true)
                    {
                        correctText.Clear();
                        posX = 0;
                        posY = 0;
                        maxLines = 0;
                        totalChar = 0;
                        seconds = 20;
                        wasExcecut = false;
                        exc = false;
                        Console.ResetColor();
                        break;
                    }
                }
            }
        }
    }
}
