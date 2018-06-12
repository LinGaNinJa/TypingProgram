using System;
using System.IO;

namespace TypingProgramV0_2
{
    public class PrefixMode : GameMode
    {
        /* 
        --------------------------------------------------------------------------------------------------------------
        選擇模式
        ----------------------------------------------
        */
        override public void ChoseExample()
        {
            ShowExample();
            ReadExample();
        }

        private void ShowExample()
        {
            Console.Clear();

            Console.WriteLine("練習 1 : dis-");
            Console.WriteLine();

            Console.WriteLine("練習 2 : inter-");
            Console.WriteLine();

            Console.WriteLine("練習 3 : pre-");
            Console.WriteLine();

            Console.WriteLine("輸入 1, 2, 3 選擇練習 1, 2, 3");

        }

        private void ReadExample()
        {
            // 使用者輸入
            int inputData = 0;
            while (true)
            {
                inputData = Convert.ToInt16(Console.ReadLine());
                if (inputData == 1 || inputData == 2 || inputData == 3) break;

                Console.WriteLine();
                Console.WriteLine("範圍必須在 1, 2, 3 之間！！");
                Console.WriteLine("請重新輸入 1, 2, 3 選擇練習 1, 2, 3");
            }

            Console.Clear();


            // 搜尋檔案夾
            string filePath = String.Format("/Users/linjialong/Projects/TypingProgramV0_2/TypingProgramV0_2/Prefix/{0:00}.txt",
                                            inputData);

            StreamReader input = new StreamReader(filePath);


            // 讓單字重複三次
            string chosenParagraph = "";
            string line;
            while (!input.EndOfStream)
            {
                line = input.ReadLine();
                for (int i = 0; i < 3; i++)
                {
                    chosenParagraph += line + " ";
                }
            }

            Console.WriteLine(chosenParagraph);
            paragraph.Content = chosenParagraph;
            paragraph.Length = chosenParagraph.Length;

        }
    }
}
