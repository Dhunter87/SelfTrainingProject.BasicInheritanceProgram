using System;
namespace SelfTrainingProject.Inheritance.cs
{
    public class Primape :Mammal
    {
        public Primape()
        {
        }
        public void Speak(string SpeechType)
        {
            if(SpeechType == "ooh")
            {
                Console.WriteLine("OOH OOH AAH AAH AAAH!");
            }

        }
    }
}
