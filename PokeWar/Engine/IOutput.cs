using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWar.Engine
{
    /// <summary>
    /// Interface to manage output.
    /// </summary>
    public interface IOutput
    {
        void UpdateDisplay(string status);
    }
}
