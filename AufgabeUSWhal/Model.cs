using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeUSWhal
{
  static class Model
  {
    static List<Person> voters = new List<Person>();
    static Random Random = new Random();
    static List<string> nachname = new List<string>();
    static List<string> vornameW = new List<string>();
    static List<string> vornameM = new List<string>();
    static List<string> vornameD = new List<string>();

    static Model()
    {
      ReadData();
    }
    public static List<Person> GetVoters()
    {
      return voters;
    }
    public static void GenerateValues(int amount)
    {
      for (int i = 0; i < amount; i++)
      {
        Geschlecht g = (Geschlecht)Random.Next(Enum.GetValues(typeof(Geschlecht)).Length);
        string vn = g switch
        {
          Geschlecht.DIVERS => vornameD[Random.Next(vornameD.Count)],
          Geschlecht.MAENLICH => vornameD[Random.Next(vornameM.Count)],
          Geschlecht.WEIBLICH => vornameD[Random.Next(vornameW.Count)]
        };

        Person p = new Person()
        {
          Namchname = nachname[Random.Next(nachname.Count)],
          PLZ = Random.Next(10000, 100000).ToString(),
          BeeEinflussbarkei = (BeeEinflussbarkei)Random.Next(Enum.GetValues(typeof(BeeEinflussbarkei)).Length),
          Alter = (Alter)Random.Next(Enum.GetValues(typeof(Alter)).Length),
          Schicht = (Schicht)Random.Next(Enum.GetValues(typeof(Schicht)).Length),
          Lager = (Lager)Random.Next(Enum.GetValues(typeof(Lager)).Length),
          Geschlecht = g,
          Vorname = vn
        };
        voters.Add(p);
      }
    }
    static void ReadData()
    {
      string line;
      using (StreamReader streamReader = new StreamReader(@"C:\Users\Osama Thabit\OneDrive - BITLC Business IT Learning Center GmbH\Desktop\Sielig-C#\AufgabeUSWhal\AufgabeUSWhal\20230615\nachnamen.txt"))
      {
        while ((line = streamReader.ReadLine()) != null)
        {
          nachname.Add(line);
        }
      }
      using (StreamReader streamReader = new StreamReader(@"C:\Users\Osama Thabit\OneDrive - BITLC Business IT Learning Center GmbH\Desktop\Sielig-C#\AufgabeUSWhal\AufgabeUSWhal\20230615\vornamen_w.txt"))
      {
        while ((line = streamReader.ReadLine()) != null)
        {
          vornameW.Add(line);
          vornameD.Add(line);
        }
      }
      using (StreamReader streamReader = new StreamReader(@"C:\Users\Osama Thabit\OneDrive - BITLC Business IT Learning Center GmbH\Desktop\Sielig-C#\AufgabeUSWhal\AufgabeUSWhal\20230615\vornamen_m.txt"))
      {
        while ((line = streamReader.ReadLine()) != null)
        {
          vornameM.Add(line);
          vornameD.Add(line);
        }
      }
    }
  }
}
