using System;
using System.Collections.Generic;
using System.Linq;

namespace AufgabeUSWhal
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Model.GenerateValues(10000);
      List<Person> voters = Model.GetVoters();

      List<Person> picklist1 = voters
        .Where(v=>v.Geschlecht == Geschlecht.DIVERS)
        .Where(v=>v.Alter == Alter.ERSWAEHLER)
        .Where(v => v.PLZ.StartsWith("3"))
        .Where(v=>v.Schicht == Schicht.OBERSCHICHT)
        .Where(v=>v.Lager == Lager.REPUBLIKANER)
        .ToList();


      PrintData (picklist1);
    }
    static void PrintData(List<Person> voters)
    {
      Console.WriteLine(new string('=', 80));
      foreach (Person person in voters)
      {
        Console.WriteLine(person);
      }
    }
  }
}
