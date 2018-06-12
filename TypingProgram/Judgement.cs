using System;
namespace TypingProgramV0_2
{
    public class Judgement
    {
        public Judgement() { }

        private string cContent; //compareContent
        private int cLength; //compareLength
        private string uContent; //userContent
        private int uLength; //userLength
        private TimeSpan uTime;

        public void Rate()
        {
            double correctCount = 0.0;
            double accuracy;
            double resultWPM;
            string elapsedTime;

            for (int i = 0; i < cLength; i++)
            {
                if (uContent[i] == cContent[i]) correctCount++;
            }

            // 準確率
            accuracy = Math.Round((correctCount / cLength), 4);

            // WPM
            double totalTime = Convert.ToDouble(uTime.TotalMinutes); // 耗時幾分鐘
            resultWPM = Math.Round((uLength / 5.0 / totalTime), 0);

            // 總耗時
            elapsedTime = String.Format("{0:00}分 {1:00}秒 {2:00}毫秒", uTime.Minutes, uTime.Seconds, uTime.Milliseconds / 10);

            // 輸出畫面
            Console.WriteLine("打字準確率：{0}％", accuracy * 100);
            Console.WriteLine();
            Console.WriteLine("每分鐘單字數：{0}", resultWPM);
            Console.WriteLine();
            Console.WriteLine("總時長：" + elapsedTime);

        }

        public void SetCompare(string s, int i)
        {
            cContent = s;
            cLength = i;
        }

        public void SetCompare(string s)
        {
            cContent = s;
        }

        public void SetCompare(int i)
        {
            cLength = i;
        }

        public void SetUser(string s, int i, TimeSpan t)
        {
            uContent = s;
            uLength = i;
            uTime = t;
        }

        public void SetUser(string s)
        {
            uContent = s;
        }

        public void SetUser(int i)
        {
            uLength = i;
        }

        public void SetUser(TimeSpan t)
        {
            uTime = t;
        }

    }
}
