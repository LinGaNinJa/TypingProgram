using System;
namespace TypingProgramV0_2
{
    public class Game
    {
        private User user = new User();
        private Judgement judgement = new Judgement();

        public void Run()
        {
            Console.WriteLine("選擇練習模式：\n1.自選文章練習\n2.七千單字練習\n3.字首字尾字根");
            Console.WriteLine();
            Console.WriteLine("輸入 1, 2, 3 選擇模式 1, 2, 3");

            int inputData = 0;
            while (true) //確保inputData在範圍之內
            {
                inputData = Convert.ToInt16(Console.ReadLine());
                if (inputData == 1 || inputData == 2 || inputData == 3) break;

                Console.WriteLine();
                Console.WriteLine("範圍必須在 1, 2, 3 之間！！");
                Console.WriteLine("請重新輸入 1, 2, 3 選擇模式 1, 2, 3");
            }

            dynamic gameMode = new GameMode();
            switch (inputData)
            {
                case 1:
                    gameMode = new ParagraphMode();
                    break;

                case 2:
                    gameMode = new VocabularyMode();
                    break;

                case 3:
                    gameMode = new PrefixMode();
                    break;
            }

            gameMode.ChoseExample();
            string s = gameMode.GetContent();
            int i = gameMode.GetLength();

            judgement.SetCompareContent(s);
            judgement.SetCompareLength(i);
            user.SetParagraphLength(i);

            Play();
        }

        private void Play()
        {
            user.Start();
            judgement.SetUserContent(user.GetContent());
            judgement.SetUserLength(user.GetLength());
            judgement.SetTimeSpan(user.GetTimeSpan()); // 總時長

            judgement.Rate();
            judgement.ShowGrade();
        }

    }
}
