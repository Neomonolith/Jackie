using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jackie
{
  class Program
  {

    static List<race> lista = new List<race>();


    static void Main(string[] args)
    {
      
      masodikfeladat();
      harmdadikfeladat();
      negyedikfeladat();
      otodikfeladat();
      hatodikfeladat();

      Console.ReadKey();
    }

    private static void hatodikfeladat()
    {
     
    }

    private static void otodikfeladat()
    {
      
    }

    private static void negyedikfeladat()
    {
      Console.WriteLine("4. Feladat: ");
      int maxev = 0, maxrace = 0;
      foreach (var l in lista)
      {
        if (l.Races>maxrace)
        {
          maxrace = l.Races;
          maxev = l.Year;
        }
      }
      Console.WriteLine($"{maxev}");

    }

    private static void harmdadikfeladat()
    {
      Console.WriteLine("3. Feladat: hány adatsort tartalmaz");
      Console.WriteLine($"{lista.Count}");

    }

    private static void masodikfeladat()
    {
      Console.WriteLine("2. Feladat: adatok beolvasása");
      StreamReader be = new StreamReader("Jackie.txt");
      
      
      be.ReadLine();


      while (!be.EndOfStream)
      {
       
        string[] a = be.ReadLine().Split('\t');
        lista.Add(new race(int.Parse(a[0]),
          int.Parse(a[1]), 
          int.Parse(a[2]), 
          int.Parse(a[3]), 
          int.Parse(a[4]), 
          int.Parse(a[5])
          )
          );
          
      }
      be.Close();


    }

    
  }
}
