using System;
namespace TypingProgramV0_2
{
    public class GameMode
    {
        protected Paragraph paragraph = new Paragraph();

        public string GetContent()
        {
            return paragraph.Content;
        }

        public int GetLength()
        {
            return paragraph.Length;
        }

        virtual public void ChoseExample() { }

    }
}
