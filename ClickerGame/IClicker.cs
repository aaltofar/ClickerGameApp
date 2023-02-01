using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame;

internal interface IClicker
{
    public int Points { get; set; }
    public void Click() { }
    public void Upgrade() { }
    public void SuperUpgrade() { }
}

