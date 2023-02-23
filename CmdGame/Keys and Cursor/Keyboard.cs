namespace CmdGame.Keys_and_Cursor
{
    using System;
    using IInterfaces;
    public class Keyboard : IKeyboard
    {
        public ConsoleKey TouchedKey
        {
            get
            {
                return Console.ReadKey().Key;
            }
        }

        public bool CanWePressKey
        {
            get
            {
                return Console.KeyAvailable;
            }
        }
    }
}
