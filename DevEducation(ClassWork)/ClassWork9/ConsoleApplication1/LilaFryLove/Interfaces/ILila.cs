namespace ConsoleApplication1.LilaFryLove.Interfaces
{
    public interface ILila
    {
        // подключаемся через интерфейс
        IFray FrayPerson { get; set; }
        void LoveFry();
        void LoveZep();
    }
}