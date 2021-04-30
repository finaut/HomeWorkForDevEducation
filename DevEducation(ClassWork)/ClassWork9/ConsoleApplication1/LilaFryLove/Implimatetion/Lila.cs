using ConsoleApplication1.LilaFryLove.Interfaces;

namespace ConsoleApplication1.LilaFryLove.Implimatetion
{
    public class Lila : ILila
    {
        public IFray FrayPerson { get; set; }

        public void LoveFry()
        {
            FrayPerson.LoveLila("Love You");
            FrayPerson.BeStupid();
        }

        public void LoveZep()
        {
            FrayPerson.BeStupid();
        }
    }
}