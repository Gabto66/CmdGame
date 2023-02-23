namespace CmdGame.VisualProps
{
    using IInterfaces;
    class Placement : IPlacement
    {
        public int Х
        {
            get;
            set;
        }

        public int У
        {
            get;
            set;
        }

        public Placement(int х, int у)
        {
            Х = х;
            У = у;
        }
        public bool Intersect(IPlacement other)
        {
            return this.Х == other.Х
                && this.У == other.У;
        }
    }
}
