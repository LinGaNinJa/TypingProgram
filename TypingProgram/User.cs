using System;
namespace TypingProgramV0_2
{
    public class User
    {
        private Paragraph paragraph = new Paragraph();
        private int paragraphLength;

        public void SetParagraphLength(int i)
        {
            paragraphLength = i;
        }

        public void Start()
        {
            // 開始計時
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            // 讀取
            char[] charList = new char[paragraphLength];

            int i = 0;
            while (i < paragraphLength)
            {
                char c;
                ConsoleKeyInfo key = Console.ReadKey();
                c = key.KeyChar;

                if (key.Key == ConsoleKey.Backspace) i--;
                if (key.Key == ConsoleKey.Enter) c = '\n';

                charList[i] = c;

                i++;
            }

            // 停止計時
            stopWatch.Stop();

            string typingContent = "";
            for (int j = 0; j < charList.Length; j++)
            {
                typingContent += charList[j];
            }

            paragraph.TimeSpan = stopWatch.Elapsed; // 總時長
            paragraph.Content = typingContent;
            paragraph.Length = typingContent.Length;
        }

        // 取得User Status
        public string GetContent()
        {
            return paragraph.Content;
        }

        public int GetLength()
        {
            return paragraph.Length;
        }

        public TimeSpan GetTimeSpan()
        {
            return paragraph.TimeSpan;
        }
    }
}
