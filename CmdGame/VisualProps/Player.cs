namespace CmdGame.VisualProps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E_nums;
    using IInterfaces;
    public class Player : IPlaying
    {
        private const Guidelines BeginGuidelines = Guidelines.Left;
        private LinkedList<IPlacement> placements;
        private readonly char character;
        public Player(char character, int beginХ, int beginУ, int startingLongitude)
        {
            this.character = character;
            this.StartPlayerBody(startingLongitude, beginУ, beginХ);
            this.Guidelines = BeginGuidelines;
        }

        public IPlacement Top
        {
            get
            {
                return this.placements.First.Value;
            }
        }
        public Guidelines Guidelines
        {
            get;
            private set;
        }

        public void Consume(IPlacement placement)
        {
            this.placements.AddLast(placement);
        }
        public void ChangeGuidelines(Guidelines newGuidelines)
        {
            switch (newGuidelines)
            {
                case Guidelines.Up:
                    if (this.Guidelines != Guidelines.Down)
                    {
                        this.Guidelines = newGuidelines;
                    }
                    break;
                case Guidelines.Down:
                    if (this.Guidelines != Guidelines.Up)
                    {
                        this.Guidelines = newGuidelines;
                    }
                    break;
                case Guidelines.Left:
                    if (this.Guidelines != Guidelines.Right)
                    {
                        this.Guidelines = newGuidelines;
                    }
                    break;
                case Guidelines.Right:
                    if (this.Guidelines != Guidelines.Left)
                    {
                        this.Guidelines = newGuidelines;
                    }
                    break;
                default: throw new ArgumentException("Not known direction");
                    
            }
        }

        public void Drive()
        {
            this.placements.RemoveLast();

            var top = this.placements.First();
            switch (this.Guidelines)
            {
                case Guidelines.Up:
                    this.placements.AddFirst(new Placement(top.Х, top.У - 1));
                    break;
                case Guidelines.Down:
                    this.placements.AddFirst(new Placement(top.Х, top.У + 1));
                    break;
                case Guidelines.Left:
                    this.placements.AddFirst(new Placement(top.Х - 1, top.У));
                    break;
                case Guidelines.Right:
                    this.placements.AddFirst(new Placement(top.Х + 1, top.У));
                    break;
                default: 
                    throw new ArgumentException("Not known direction");  
            }
        }

        public void Drаw(IDraw draw)
        {
            foreach (var placement in this.placements)
            {
                draw.DrаwPoint(placement.Х, placement.У, this.character);
            }
            var latter = this.placements.Last;
            draw.DrаwPoint(latter.Value.Х, latter.Value.У, ' ');
            
        }
        private void StartPlayerBody(int startingLongitude, int beginУ, int beginХ)
        {
            this.placements = new LinkedList<IPlacement>();
            for (int i = 0; i < startingLongitude; i++)
            {
                this.placements.AddLast(new Placement(i + beginХ, beginУ));
            }
        }
    }
}
