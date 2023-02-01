using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame;

public class User
{
    public string Name { get; private set; }
    public int Points => GetSumPoints();
    public List<AutoClicker> Clickers { get; set; }

    public Clicker MainClicker;

    public User()
    {
        MainClicker = new Clicker();
    }
    public void SetName(string input)
    {
        Name = input;
    }

    public void PrintDetails()
    {

    }

    public int GetSumPoints()
    {
        var result = 0;
        foreach (var c in Clickers)
            result += c.Points;

        return result + MainClicker.Points;
    }
}



