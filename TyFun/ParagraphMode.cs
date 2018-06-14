using System;
using System.IO;

namespace TyFun
{

    public class ParagraphMode : GameMode
    {
        override public void Start()
        {
            Name = "Paragraph Mode";
            Random random = new Random();

            // 搜尋檔案夾
            StreamReader input = new StreamReader("/Users/linjialong/Projects/TyFun/packages/Microsoft.CSharp.4.5.0/ref/GameMode/Paragraph.txt");
            string temp = input.ReadToEnd();

            string[] separatingChars = { "段落\n" };
            string[] allContent = temp.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);
            string chosenParagraph = allContent[random.Next(allContent.Length)];

            Console.WriteLine(chosenParagraph);
            paragraph.Content = chosenParagraph;
            paragraph.Length = chosenParagraph.Length;
        }

    }
}
