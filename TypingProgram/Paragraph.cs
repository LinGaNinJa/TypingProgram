using System;
namespace TypingProgramV0_2
{
	public class Paragraph
	{
		private string content; // 內容
		private int length; // 長度
		private TimeSpan timeSpan; // 時間

		public string Content
		{
			set { content = value; }
			get { return content; }
		}

		public int Length
		{
			set { length = value; }
			get { return length; }
		}

		public TimeSpan TimeSpan
		{
			set { timeSpan = value; }
			get { return timeSpan; }
		}


		public Paragraph() { }

	}
}