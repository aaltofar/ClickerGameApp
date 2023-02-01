using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame;

public class AutoClicker : IClicker
{
    public int Points { get; set; }
    public int _clickTimer = 10000;

    //async public void Click(User player)
    //{
    //    while (true)
    //    {
    //        await Task.Delay(5000);
    //        player.Points += _pointsPerClick;
    //        //Console.WriteLine("Hei jeg klikket");
    //        //Console.WriteLine(_mld);
    //        //Thread.Sleep(5000);
    //    }
    //}
}

