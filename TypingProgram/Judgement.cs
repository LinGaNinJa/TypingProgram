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

		public void SetCompareContent(string s)
		{
			cContent = s;
		}

		public void SetCompareLength(int i)
		{
			cLength = i;
		}

		public void SetUserContent(string s)
		{
			uContent = s;
		}

		public void SetUserLength(int i)
		{
			uLength = i;
		}

		public void SetTimeSpan(TimeSpan t)
		{
			uTime = t;
		}

		private double correctCount;
		private double accuracy;
		private double resultWPM;
		private string elapsedTime;


		public void Rate()
		{
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
		}

		public void ShowGrade()
		{
			Console.WriteLine("打字準確率：{0}％", accuracy * 100);
			Console.WriteLine();

			Console.WriteLine("每分鐘單字數：{0}", resultWPM);
			Console.WriteLine();

			Console.WriteLine("總時長：" + elapsedTime);
		}
	}
}
