using System;

namespace ClassWork17
{
    public interface myNewInterface
    {
        event Action<int> Help;

        public void Simple(int i); 

    }
}