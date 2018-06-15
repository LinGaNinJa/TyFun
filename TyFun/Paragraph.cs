using System;
namespace TyFun
{
    public class Paragraph
    {
        private string content; // 內容
        private int length; // 長度

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

        public Paragraph() { }

    }
}