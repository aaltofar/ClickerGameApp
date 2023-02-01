using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame;

public class Clicker : IClicker
{
    public int _pointsPerClick = 1;
    public int _pointsPerClickIncrease = 1;
    public int Points { get; set; }
    private string _mld { get; set; }

    public Clicker(string mld = null)
    {
        _mld = mld;
    }

    public void Click()
    {
        Points += _pointsPerClick;
    }

    public void Upgrade(User player)
    {
        Points -= 10;
        _pointsPerClick += _pointsPerClickIncrease;
    }

    public void SuperUpgrade(User player)
    {
        Points -= 100;
        _pointsPerClickIncrease++;
    }
}

