namespace CmdGame.IInterfaces
{
    using E_nums;
    public interface IMoving
    {
        void Drive();
        Guidelines Guidelines { get; }
        void ChangeGuidelines(Guidelines newGuidelines);
    }
}
