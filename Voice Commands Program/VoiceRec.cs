using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace Voice_Commands_Program
{
    public class VoiceRec
    {
        

        public static void Main1(string[] args) //Voice Recognition code 
        {

            
            // Speech Recognizer object construction
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
            // Assigning a handle to the speech recognition event
            sre.SpeechRecognized += Sre_SpeechRecognized;
            // Loading standard English dictionary
            sre.LoadGrammar(new DictationGrammar());
            // Set input audio device to the system default
            sre.SetInputToDefaultAudioDevice();
            // Start recognizing input
            sre.RecognizeAsync(RecognizeMode.Multiple);

            // Prevent the console from closing
            // Pressing ENTER closes the program
            Console.ReadLine();
        }


        public static void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) //Voice Recognition code
        {


            // Writes the recognized sentence to the console
            //Console.WriteLine(e.Result.Text);

            String input;
            input = e.Result.Text;
            Console.WriteLine(input);
            
            
            

            if ((input.Contains("What")) || (input.Contains("what")))
            {

                //Shows What Form
                What W = new What();
                W.Show();
            }
            else if ((input.Contains("How")) || (input.Contains("how")))
            {
                //Shows How it works video

                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=yxxRAHVtafI&t=220s");

            }
            else if ((input.Contains("Where")) || (input.Contains("where")))
            {
                //Shows What Form
                Where H = new Where();
                H.Show();
            }
            else if ((input.Contains("When")) || (input.Contains("when")) || (input.Contains("begin")) || (input.Contains("Begin")))
            {
                //Shows What Form
                
                When N = new When();
                N.Show();
            }



            //bool b = input.Contains(substr1);
            //Console.WriteLine(input.Contains(substr1));
        }
    }
}
