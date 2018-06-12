using System;
using System.IO;

namespace TypingProgramV0_2
{

    public class ParagraphMode : GameMode
    {
        /* 
        --------------------------------------------------------------------------------------------------------------
        選擇模式
        ----------------------------------------------
        */
        public void ChoseExample()
        {
            ShowExample();
            ReadExample();
        }

        private void ShowExample()
        {
            Console.Clear();

            Console.WriteLine("文章 1");
            Console.WriteLine("Once when I was six years old I saw a magnificent picture in a book, " +
                              "called True Stories from Nature, about the primeval forest. " +
                              "It was a picture of a boa constrictor in the act of swallowing an animal. Here is a copy of the drawing.");
            Console.WriteLine();

            Console.WriteLine("文章 2");
            Console.WriteLine("In the book it said: " +
                              "\"Boa constrictors swallow their prey whole, without chewing it." +
                              "After that they are not able to move, and they sleep through the six months that they need for digestion.\"");
            Console.WriteLine();

            Console.WriteLine("文章 3");
            Console.WriteLine("I pondered deeply, then, over the adventures of the jungle. " +
                              "And after some work with a colored pencil I succeeded in making my first drawing. " +
                              "My Drawing Number One.");

            Console.WriteLine();
            Console.WriteLine("輸入 1, 2, 3 選擇文章 1, 2, 3");

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
                Console.WriteLine("請重新輸入 1, 2, 3 選擇文章 1, 2, 3");
            }

            Console.Clear();


            // 搜尋檔案夾
            string filePath = String.Format("/Users/linjialong/Projects/TypingProgramV0_2/TypingProgramV0_2/Paragraph/{0:00}.txt",
                                            inputData);

            StreamReader input = new StreamReader(filePath);
            string chosenParagraph = input.ReadToEnd();

            Console.WriteLine(chosenParagraph);
            paragraph.Content = chosenParagraph;
            paragraph.Length = chosenParagraph.Length;

        }
    }
}
