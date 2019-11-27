using System;

namespace TurnUp.CustomExceptions
{
    public class NoSuchDriverFound: Exception
    {
        public NoSuchDriverFound(string message): base(message)
        {
            Console.WriteLine(message);
        }
    }
}
