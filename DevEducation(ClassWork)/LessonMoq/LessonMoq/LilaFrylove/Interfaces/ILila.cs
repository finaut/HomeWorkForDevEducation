using System;
using System.Collections.Generic;
using System.Text;

namespace LessonMoq.LilaFrylove.Interfaces
{
    public interface ILila
    {
        IFry Fry { get; set; }
        void LoveFry();
        void LoveZep();
    }
}
