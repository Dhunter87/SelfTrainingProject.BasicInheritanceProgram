using System;
namespace SelfTrainingProject.Inheritance.cs
{
    public class Feliformia : Carnivore
    {
        public Feliformia()
        {
        }
        public void Speak(string SpeechType)
        {
            if (SpeechType == "Meow")
            {
                Console.WriteLine("MEEOOOWW!");
            }
            else if (SpeechType == "Roar")
            {
                Console.WriteLine("Roooaaarrr!");
            }
        }

    }
}
