using System;
using System.Threading;


class Program {
    
  static void Ascii(){
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
  }
  static void Menu(){
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
    if (izvele == 1){
      MenuAdd();
    }
    else if (izvele == 2){
      MenuView();
    }
    else if (izvele == 3){
      MenuDelete();
    }
    else if (izvele == 4){
      MenuSearch();
    }
    else if(izvele == 5){}
    else if (izvele == 6){}
    else {
      Console.Clear();
      Console.WriteLine("VISU LABU!");
      Environment.Exit(0);
    }
  }

  static void MenuAdd(){
    Console.Clear();
    Console.WriteLine(@"
----------------------------------
  CIETUMA PARVALDISANAS SISTEMA
----------------------------------

Izvelieties tabulu, kura pievienot datus:
* 1 - Cietumnieks
* 2 - Apsargs
* 3 - Cietuma kamera
* 4 - Atpakal");
    Console.Write("Ievadiet izveli: ");
    int izvele2 = Convert.ToInt32(Console.ReadLine());
    if (izvele2 > 0 && izvele2 < 4){}
    else if (izvele2 == 4) {
      Console.Clear();
      Menu();
    }
    else {
      Console.WriteLine("Kluda. Tiekat novirzits uz galveno izvelni.");
      Thread.Sleep(1000);
      Console.Clear();
      Menu();
    }
  }
  
  static void MenuView(){
    Console.Clear();
    Console.WriteLine(@"
----------------------------------
  CIETUMA PARVALDISANAS SISTEMA
----------------------------------

Izvelieties tabulu, kura velaties skatit datus:
* 1 - Cietumnieks
* 2 - Apsargs
* 3 - Cietuma kamera
* 4 - Atpakal");
    Console.Write("Ievadiet izveli: ");
    int izvele2 = Convert.ToInt32(Console.ReadLine());
    if (izvele2 > 0 && izvele2 < 4){}
    else if (izvele2 == 4) {
      Console.Clear();
      Menu();
    }
    else {
      Console.WriteLine("Kluda. Tiekat novirzits uz galveno izvelni.");
      Thread.Sleep(1000);
      Console.Clear();
      Menu();
    }
  }
    
  static void MenuDelete(){
    Console.Clear();
    Console.WriteLine(@"
----------------------------------
  CIETUMA PARVALDISANAS SISTEMA
----------------------------------

Izvelieties tabulu, no kuras velaties dzest datus:
* 1 - Cietumnieks
* 2 - Apsargs
* 3 - Cietuma kamera
* 4 - Atpakal");
    Console.Write("Ievadiet izveli: ");
    int izvele2 = Convert.ToInt32(Console.ReadLine());
    if (izvele2 > 0 && izvele2 < 4){}
    else if (izvele2 == 4) {
      Console.Clear();
      Menu();
    }
    else {
      Console.WriteLine("Kluda. Tiekat novirzits uz galveno izvelni.");
      Thread.Sleep(1000);
      Console.Clear();
      Menu();
    }
  }
    
  static void MenuSearch(){
    Console.Clear();
    Console.WriteLine(@"
----------------------------------
  CIETUMA PARVALDISANAS SISTEMA
----------------------------------

Izvelieties tabulu, kura meklet datus:
* 1 - Cietumnieks
* 2 - Apsargs
* 3 - Cietuma kamera
* 4 - Atpakal");
    
    Console.Write("Ievadiet izveli: ");
    int izvele2 = Convert.ToInt32(Console.ReadLine());
    if (izvele2 > 0 && izvele2 < 4){}
    else if (izvele2 == 4) {
      Console.Clear();
      Menu();
    }
    else {
      Console.WriteLine("Kluda. Tiekat novirzits uz galveno izvelni.");
      Thread.Sleep(1000);
      Console.Clear();
      Menu();
    }
  }

  public static void Main (string[] args) {
    Ascii();
    Menu();
  }
}
