using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackie
{
  class race
  {
    private int year;

    public int Year
    {
      get { return year; }
      set { year = value; }
    }


    private int races;

    public int Races
    {
      get { return races; }
      set { races = value; }
    }

    private int wins;

    public int Wins
    {
      get { return wins; }
      set { wins = value; }
    }


    private int podiums;

    public int Podiums
    {
      get { return podiums; }
      set { podiums = value; }
    }


    private int poles;

    public int Poles
    {
      get { return poles; }
      set { poles = value; }
    }


    private int fastests;

    public int Fastests
    {
      get { return fastests; }
      set { fastests = value; }
    }

    public race(int year, int races, int wins, int podiums, int poles, int fastests)
    {
      this.year = year;
      this.races = races;
      this.wins = wins;
      this.podiums = podiums;
      this.poles = poles;
      this.fastests = fastests;
    }
  }
}
