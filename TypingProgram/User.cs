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
            string typingContent = Console.ReadLine();

            // 建立一個字串來紀錄使用者實際輸入的字，方便計算wpm
            string typingLength = typingContent;

            // 停止計時
            stopWatch.Stop();

            //補滿字數不足的區域
            for (int i = typingContent.Length; i < paragraphLength; i++)
            {
                typingContent += '\u2328';
            }

            paragraph.TimeSpan = stopWatch.Elapsed; // 總時長
            paragraph.Content = typingContent;
            paragraph.Length = typingLength.Length;
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
