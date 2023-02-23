namespace CmdGame.Keys_and_Cursor
{
    using System;
    using IInterfaces;
    class CmdDraw : IDraw
    {

        public void DrаwPoint(int х, int у, char character)
        {
            Console.SetCursorPosition(х, у);

            Console.Write(character);
        }
    }
}
