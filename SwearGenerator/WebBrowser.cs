
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Threading;
using System.Speech.Synthesis;

namespace SwearGenerator
{
    public partial class WebBrowser : Form
    {
        public WebBrowser(bool clipBoard, int instances)
        {
            InitializeComponent();
            
            if (clipBoard == true)
            {
                SwearGenerator.GlobalVars.clipboard = 1;
            }
            else
            {
                SwearGenerator.GlobalVars.clipboard = 0;
            }
            SwearGenerator.GlobalVars.instances = instances;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("http://foulomatic.hnldesign.nl/");
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

            

            

        }

        async Task LoadingTime(int milis)
        {
            await Task.Delay(milis);
        }

        private static string ReadLine(string text, int lineNumber)
        {
            var reader = new StringReader(text);

            string line;
            int currentLineNumber = 0;

            do
            {
                currentLineNumber += 1;
                line = reader.ReadLine();
            }
            while (line != null && currentLineNumber < lineNumber);

            return (currentLineNumber == lineNumber) ? line :
                                                       string.Empty;
        }

        private async void webBrowser1_DocumentCompleted(Object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            if (e.Url.Equals(webBrowser1.Url))
            {
                if (SwearGenerator.GlobalVars.instances == 1)
                {
                    await LoadingTime(2000);
                    SwearGenerator.GlobalVars.generateStatus = "Working - Generating SwearWord";
                    Console.WriteLine("Now it is really done");
                    webBrowser1.Document.ExecCommand("SelectAll", false, null);
                    webBrowser1.Document.ExecCommand("Copy", false, null);
                    Properties.Settings.Default.lastSwear = Clipboard.GetText();
                    Console.WriteLine(Properties.Settings.Default.lastSwear);
                    Properties.Settings.Default.lastSwear = ReadLine(Properties.Settings.Default.lastSwear, 26);
                    SwearGenerator.GlobalVars.sessionGenerated.Add(Properties.Settings.Default.lastSwear);
                    
                    SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                    synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
                    synthesizer.Volume = 100;  // 0...100
                    synthesizer.Rate = -2;     // -10...10

                    // Asynchronous
                    Console.WriteLine(Properties.Settings.Default.lastSwear);
                    Console.WriteLine("synth");
                    synthesizer.SpeakAsync(Properties.Settings.Default.lastSwear);
                    MessageBox.Show(Properties.Settings.Default.lastSwear);
                    if (SwearGenerator.GlobalVars.clipboard == 1)
                    {
                        System.Windows.Forms.Clipboard.SetText(Properties.Settings.Default.lastSwear);
                    }
                }
                else
                {
                    for (int i = 0; i < SwearGenerator.GlobalVars.instances; i++)
                    {
                        if (i >= 1) { webBrowser1.Refresh(); await LoadingTime(2000); }
                        else
                        {
                            await LoadingTime(2000);
                        }
                        string instances= 
                        SwearGenerator.GlobalVars.generateStatus = "Working - Generating " + (i+1) + " out of " + SwearGenerator.GlobalVars.instances.ToString();
                        Console.WriteLine("Now it is really done");
                        webBrowser1.Document.ExecCommand("SelectAll", false, null);
                        webBrowser1.Document.ExecCommand("Copy", false, null);
                        Properties.Settings.Default.lastSwear = Clipboard.GetText();
                        Console.WriteLine(Properties.Settings.Default.lastSwear);
                        Properties.Settings.Default.lastSwear = ReadLine(Properties.Settings.Default.lastSwear, 26);
                        SwearGenerator.GlobalVars.sessionGenerated.Add(Properties.Settings.Default.lastSwear);
                    }
                    SwearGenerator.GlobalVars.generateStatus = "Done! - Generated " + SwearGenerator.GlobalVars.instances.ToString() + " SwearWords, Have Fun!";
                        string tempgen="Words generated this session:\n";
                        foreach (string j in SwearGenerator.GlobalVars.sessionGenerated)
                        {
                           tempgen += ( "\n\t" + j);
                        }
                    SwearGenerator.GlobalVars.generateStatus = "Working - Saving new SwearWords";
                        /* foreach (string k in SwearGenerator.GlobalVars.sessionGenerated)
                        {
                        Properties.Settings.Default.allSwearsGenerated.Add(k);
                        }*/
                        //Properties.Settings.Default.Save();
                        
                        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                        synthesizer.SelectVoiceByHints(VoiceGender.Male , VoiceAge.Adult);
                        synthesizer.Volume = 100;  // 0...100
                        synthesizer.Rate = -2;     // -10...10

                    // Asynchronous
                    Console.WriteLine(tempgen);
                    Console.WriteLine("synth");
                    synthesizer.SpeakAsync(tempgen);
                    MessageBox.Show(tempgen);

                    SwearGenerator.GlobalVars.sessionGenerated.Clear();
                    SwearGenerator.GlobalVars.generateStatus = "Idle - Waiting";
                }
                    


                
            }       
                 
                
            
        
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {
        
        }
    }
}
