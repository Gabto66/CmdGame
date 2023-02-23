namespace CmdGame.IInterfaces
{
    using System;
    public interface IKeyboard
    {
        ConsoleKey TouchedKey { get; }

        bool CanWePressKey { get; }
    }
}
