using System;
namespace SelfTrainingProject.Inheritance.cs
{
    public class Bird :Vertebrate
    {
        public Bird()
        {
        }

        public void Speak(string SpeechType)
        {
            if(SpeechType == "chirp")
            {
                Console.WriteLine("Churp churp churp!");
            }
            else if (SpeechType == "squark")
            {
                Console.WriteLine("Squark Squark!");
            }
            else if (SpeechType == "woo")
            {
                Console.WriteLine("Wooooo Wooooo!");
            }
        }

        //public void Speak()
        //{
        //    Console.WriteLine("Skquark Squark!");
        //}
    }
}
