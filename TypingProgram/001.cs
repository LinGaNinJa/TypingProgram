using System;
namespace TypingProgramV0_2
{
	public class EmptyClass
	{
		public EmptyClass()
		{
			/* 
			 --------------------------------------------------------------------------------------------------------------
			 文章讀入
			 ----------------------------------------------
			*/

			string paragraph01 = "Once when I was six years old I saw a magnificent picture in a book,";
			string paragraph02 = "In the book it said: \"Boa constrictors swallow their prey whole, without chewing it.";
			string paragraph03 = "I pondered deeply, then, over the adventures of the jungle.";

			/* 
			 --------------------------------------------------------------------------------------------------------------
			 使用者選擇要哪個文章
			 ----------------------------------------------
			*/

			Console.WriteLine("段落 1");
			Console.WriteLine("Once when I was six years old I saw a magnificent picture in a book, " +
							  "called True Stories from Nature, about the primeval forest. " +
							  "It was a picture of a boa constrictor in the act of swallowing an animal. Here is a copy of the drawing.");
			Console.WriteLine();

			Console.WriteLine("段落 2");
			Console.WriteLine("In the book it said: " +
							  "\"Boa constrictors swallow their prey whole, without chewing it." +
							  "After that they are not able to move, and they sleep through the six months that they need for digestion.\"");
			Console.WriteLine();

			Console.WriteLine("段落 3");
			Console.WriteLine("I pondered deeply, then, over the adventures of the jungle. " +
							  "And after some work with a colored pencil I succeeded in making my first drawing. " +
							  "My Drawing Number One.");

			Console.WriteLine();
			Console.WriteLine("輸入 1, 2, 3 選擇段落 1, 2, 3");

			int inputData = 0;
			while (true)
			{
				inputData = Convert.ToInt16(Console.ReadLine());
				if (inputData == 1 || inputData == 2 || inputData == 3) break;

				Console.WriteLine();
				Console.WriteLine("範圍必須在 1, 2, 3 之間！！");
				Console.WriteLine("請重新輸入 1, 2, 3 選擇段落 1, 2, 3");
			}

			Console.Clear();

			string chosen = "";
			switch (inputData)
			{
				case 1:
					Console.WriteLine(paragraph01);
					chosen = paragraph01;
					break;
				case 2:
					Console.WriteLine(paragraph02);
					chosen = paragraph02;
					break;
				case 3:
					Console.WriteLine(paragraph03);
					chosen = paragraph03;
					break;
				default:
					Console.WriteLine("Wrong!!");
					break;
			}

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
			TimeSpan timeSpan = stopWatch.Elapsed; // 總時長
			double totalTime = Convert.ToDouble(stopWatch.Elapsed.TotalMinutes); // 耗時幾分鐘

			//補滿字數不足的區域
			for (int i = typingContent.Length; i < chosen.Length; i++)
			{
				typingContent += '\u2328';
			}


			/* 
			 --------------------------------------------------------------------------------------------------------------
			 比對使用者輸入內容與段落
			 ----------------------------------------------
			*/

			double count = 0;
			for (int i = 0; i < chosen.Length; i++)
			{
				if (typingContent[i] == chosen[i]) count++;
			}

			/* 
			 --------------------------------------------------------------------------------------------------------------
			 計算並輸出數據
			 ----------------------------------------------
			*/
			Console.Clear();

			// 準確率
			double paragraphLength = chosen.Length;
			double accuracy = 0;
			accuracy = Math.Round((count / paragraphLength), 4);
			Console.WriteLine("打字準確率：{0}％", accuracy * 100);
			Console.WriteLine();

			// WPM
			double wpmLength = typingLength.Length;
			double resultWPM = 0;
			resultWPM = Math.Round((wpmLength / 5.0 / totalTime), 0);
			Console.WriteLine("每分鐘單字數：{0}", resultWPM);
			Console.WriteLine();

			// 總耗時
			string elapsedTime = String.Format("{0:00}分 {1:00}秒 {2:00}毫秒",
			timeSpan.Minutes, timeSpan.Seconds,
			timeSpan.Milliseconds / 10);
			Console.WriteLine("總時長：" + elapsedTime);

		}
	}
}
