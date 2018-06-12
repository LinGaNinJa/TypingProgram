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
			//計算時間
			System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
			stopWatch.Start();

			/* 
             --------------------------------------------------------------------------------------------------------------
             使用者開始輸入
             ----------------------------------------------
            */

			// 讀取
			string typingContent = Console.ReadLine();
			string typingLength = typingContent; // 建立一個使用者實際輸入的字的字串來計算wpm

			// 開始計時
			stopWatch.Stop();
			paragraph.TimeSpan = stopWatch.Elapsed; // 總時長
			double totalTime = Convert.ToDouble(stopWatch.Elapsed.TotalMinutes); // 耗時幾分鐘

			//補滿字數不足的區域
			for (int i = typingContent.Length; i < paragraphLength; i++)
			{
				typingContent += '\u2328';
			}

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
