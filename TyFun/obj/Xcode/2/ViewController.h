// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface ViewController : NSViewController {
}
@property (weak) IBOutlet NSTextField *GameModeLabel;
@property (weak) IBOutlet NSBox *BGBox;
@property (weak) IBOutlet NSTextField *TextArea;
@property (weak) IBOutlet NSBox *VerticalLine;
@property (weak) IBOutlet NSBox *HorizontalLine;
@property (weak) IBOutlet NSTextField *AccuracyText;
@property (weak) IBOutlet NSTextField *SpeedText;
@property (weak) IBOutlet NSTextField *DurationText;
@property (weak) IBOutlet NSTextField *AccuracyNum;
@property (weak) IBOutlet NSTextField *SpeedNum;
@property (weak) IBOutlet NSTextField *DurationNum;
@property (weak) IBOutlet NSBox *BGBoxWhite;
@property (weak) IBOutlet NSTextField *InputBox;

- (IBAction)ParagraphButton:(id)sender;
- (IBAction)VocabularyButton:(id)sender;
- (IBAction)PrefixButton:(id)sender;
- (IBAction)SaveText:(id)sender;

@end
