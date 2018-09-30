using System;

namespace SelfTrainingProject.Inheritance.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Gorilla gorilla = new Gorilla();
            gorilla.Eat();
            gorilla.Speak(gorilla.SpeechType);

            Chimpanzee chimpanzee = new Chimpanzee();
            chimpanzee.Eat();
            chimpanzee.Speak(chimpanzee.SpeechType);

            Sphynx sphynx = new Sphynx();
            sphynx.Eat();
            sphynx.Speak(sphynx.SpeechType);

            Bengal bengal = new Bengal();
            bengal.Eat();
            bengal.Speak(bengal.SpeechType);

            Tiger tiger = new Tiger();
            tiger.Eat();
            tiger.Speak(tiger.SpeechType);

            Lion lion = new Lion();
            lion.Eat();
            lion.Speak(lion.SpeechType);

            Staff staff = new Staff();
            staff.Eat();
            staff.Speak(staff.SpeechType);

            Poodle poodle = new Poodle();
            poodle.Eat();
            poodle.Speak(poodle.SpeechType);

            Hawk hawk = new Hawk();
            hawk.Eat();
            hawk.Speak(hawk.SpeechType);

            Owl owl = new Owl();
            owl.Eat();
            owl.Speak(owl.Speechtype);

            RobinRedBreast robinRedBreast = new RobinRedBreast();
            robinRedBreast.Eat();
            robinRedBreast.Speak(robinRedBreast.SpeechType);

            GreyWolf greyWolf = new GreyWolf();
            greyWolf.Eat();
            greyWolf.Speak(greyWolf.SpeechType);



        }
    }
}
