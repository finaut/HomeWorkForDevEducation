using LessonMoq.LilaFrylove.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LessonMoq.LilaFrylove.Implementation
{
    public class Lila : ILila
    {
        public IFry Fry { get; set; }

        public void LoveFry()
        {
           // Fry.LoveLila("Love you");
            Fry.BeStupid();
        }

        public void LoveZep()
        {
            Fry.BeStupid();
        }
    }
}
