using System;
namespace SelfTrainingProject.Inheritance.cs
{
    public class Caniformia : Carnivore
    {
        public Caniformia()
        {
        }
        public void Speak(string SpeechType)
        {
            if (SpeechType == "Woof")
            {
                Console.WriteLine("WOOF! WOOF!");
            }
            else if (SpeechType == "Howl")
            {
                Console.WriteLine("Hooowwwllll!");
            }
        }
    }
}
