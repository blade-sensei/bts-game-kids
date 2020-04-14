using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace jeux
{
     public class Outils
    {
        public Outils()
        { }


        static public void bonneReponse()
        {
            SoundPlayer right = new SoundPlayer("Correct-answer.wav");
            right.Play();
        }
        static public void mauvaiseReponse()
        {
            SoundPlayer wrong = new SoundPlayer("wrong-answer.wav");
            wrong.Play();
        }
    }
}
