namespace AufgabeUSWhal
{
  enum BeeEinflussbarkei { LEICHT, MITTEL, SCHWER }
  enum Alter { ERSWAEHLER, BIS30, BIS40, BIS60, SONSTIGE }
  enum Geschlecht { MAENLICH, WEIBLICH, DIVERS }
  enum Schicht { UNTERSCHICHT, UNTERMITTEL, OBEREMITTELSCHICHT, OBERSCHICHT }
  enum Lager { REPUBLIKANER, DEMOKRATEN }
  internal class Person
  {
    private static int nextId = 1;
    public int Id { get; private set; }/// private set
    public string Vorname { get; set; }
    public string Namchname { get; set; }
    public string PLZ { get; set; }
    public Geschlecht Geschlecht { get; set; }
    public Alter Alter { get; set; }
    public Schicht Schicht { get; set; }
    public Lager Lager { get; set; }
    public BeeEinflussbarkei BeeEinflussbarkei { get; set; }

    public Person()
    {
      Id = nextId;
      nextId++;
    }
    public override string ToString()
    {
      return $"{Id,5} {Vorname} {Namchname} {PLZ} {Geschlecht} {Alter} {Schicht} {Lager} {BeeEinflussbarkei}";
    }

  }
}
