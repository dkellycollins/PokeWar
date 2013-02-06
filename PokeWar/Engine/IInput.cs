using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWar.Engine
{
    /// <summary>
    /// Interface for managing input.
    /// </summary>
    public interface IInput
    {
        int SelectAceCard(string msg);
        int SelectCard(string msg);
    }
}
