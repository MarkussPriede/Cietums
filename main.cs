using System;
using System.Threading;

class Program {
    
  static void Menu(){
    Console.WriteLine(@"
**************************************************
*                    CIETUMS                     *
**************************************************
        =================================
         ||     ||<(.)>||<(.)>||     || 
         ||    _||     ||     ||_    || 
         ||   (__D     ||     C__)   || 
         ||   (__D     ||     C__)   ||
         ||   (__D     ||     C__)   ||
         ||   (__D     ||     C__)   ||
         ||     ||     ||     ||     ||  
        ================================");
    Thread.Sleep(1000);
    Console.Clear();
    
    Console.WriteLine(@"
----------------------------------
  CIETUMA PARVALDISANAS SISTEMA
----------------------------------

Main menu:
* 1 - Pievienot datus
* 2 - Skatit datus
* 3 - Dzest datus
* 4 - Meklet datus
* 5 - Kopsavilkums
* 6 - Kartot
* 7 - Iziet
__________________________________");
    
    Console.Write("Ievadiet izveli: ");
    int izvele = Convert.ToInt32(Console.ReadLine());
    if (izvele < 5 && izvele > 0){
      Menu2();
    }
    else if(izvele == 5){}
    else if (izvele == 6){}
    else {
      Console.Clear();
      Console.WriteLine("VISU LABU!");
      Environment.Exit(0);
    }
  }

  static void Menu2(){
    Console.Clear();
    Console.WriteLine(@"
----------------------------------
  CIETUMA PARVALDISANAS SISTEMA
----------------------------------

Izvelieties tabulu:
* 1 - Cietumnieks
* 2 - Apsargs
* 3 - Cietuma kamera");
    
    Console.Write("Ievadiet izveli: ");
    int izvele2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(izvele2);
  }
  
  public static void Main (string[] args) {
    Menu();
  }
}
