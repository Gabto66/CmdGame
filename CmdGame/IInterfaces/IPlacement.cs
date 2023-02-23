using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdGame.IInterfaces
{
    public interface IPlacement
    {
        int Х { get; set; }
        int У { get; set; }
        bool Intersect(IPlacement other);
    }
}
