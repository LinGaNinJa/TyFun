using System;
namespace TyFun
{
    public class Judgement
    {
        public Judgement() { }

        private string cContent; //compareContent
        private int cLength; //compareLength
        private string uContent; //userContent
        private int uLength; //userLength
        private TimeSpan uTime;

        public (double accuracy, double speed) Rate()
        {
            double correctCount = 0.0;
            double accuracy;
            double resultWPM;

            for (int i = 0; i < cLength; i++)
            {
                if (uContent[i] == cContent[i]) correctCount++;
            }

            // 準確率
            accuracy = Math.Round((correctCount / cLength), 4) * 100;

            // WPM
            double totalTime = Convert.ToDouble(uTime.TotalMinutes); // 耗時幾分鐘
            resultWPM = Math.Round((uLength / 5.0 / totalTime), 0);

            // 輸出畫面
            return (accuracy, resultWPM);

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

        public void SetInput(string s, int i, TimeSpan t)
        {
            uContent = s;
            uLength = i;
            uTime = t;
        }

        public void SetInput(string s)
        {
            uContent = s;
        }

        public void SetInput(int i)
        {
            uLength = i;
        }

        public void SetInput(TimeSpan t)
        {
            uTime = t;
        }

    }
}
