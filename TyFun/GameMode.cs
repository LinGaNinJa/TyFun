using System;
namespace TyFun
{
    public class GameMode
    {
        protected Paragraph paragraph = new Paragraph();

        protected string name;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string GetContent()
        {
            return paragraph.Content;
        }

        public int GetLength()
        {
            return paragraph.Length;
        }

        virtual public void Start() { }

    }
}
