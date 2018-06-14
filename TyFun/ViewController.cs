using System;

using AppKit;
using Foundation;

namespace TyFun
{
    public partial class ViewController : NSViewController
    {
        private Judgement judgement = new Judgement();
        private dynamic gameMode = new GameMode();
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        TimeSpan time;
        string input;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        partial void ParagraphButton(NSObject sender)
        {
            gameMode = new ParagraphMode();
            Play();
        }

        partial void VocabularyButton(NSObject sender)
        {
            gameMode = new VocabularyMode();
            Play();
        }

        partial void PrefixButton(NSObject sender)
        {
            gameMode = new PrefixMode();
            Play();
        }

        partial void SaveText(NSObject sender)
        {
            stopwatch.Stop();
            time = stopwatch.Elapsed;

            input = InputBox.StringValue;
            int length = gameMode.GetLength();
            int inputLength = input.Length;

            for (int i = inputLength; i < length; i++)
            {
                input += '\u2328';
            }
            ShowResult();
        }

        private void Reset()
        {
            stopwatch.Reset();
            AccuracyNum.StringValue = "0%";
            SpeedNum.StringValue = "0wpm";
            DurationNum.StringValue = "00:00";
        }

        private void ShowResult()
        {
            judgement.SetInput(input, input.Length, time);
            var result = judgement.Rate();

            AccuracyNum.StringValue = String.Format("{0}%", result.accuracy);
            SpeedNum.StringValue = String.Format("{0}wpm", result.speed);
            DurationNum.StringValue = String.Format("{0:00}:{1:00}", time.Minutes, time.Seconds);
        }

        private void Play()
        {
            Reset();
            stopwatch.Start();

            gameMode.Start();
            GameModeLabel.StringValue = gameMode.Name;

            string s = gameMode.GetContent();
            int i = gameMode.GetLength();

            judgement.SetCompare(s, i);
            TextArea.StringValue = s;

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            GameModeLabel.StringValue = "Game Start";
            AccuracyText.StringValue = "Accuracy";
            DurationText.StringValue = "Duration";
            SpeedText.StringValue = "Speed";
        }


        public override void ViewWillAppear()
        {
            base.ViewWillAppear();
            this.View.Window.Title = "TyFun";
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
