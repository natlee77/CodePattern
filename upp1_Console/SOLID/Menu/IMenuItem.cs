using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Menu
{
    public interface IMenuItem
    {
        string Name { get; set; }
        Action RunThis { get; set; }
        int Selector { get; set; }
    }
}