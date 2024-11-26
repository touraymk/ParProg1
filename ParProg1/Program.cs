// denne oppgaven skal du prøve å programmere deg selv 🤓
// Du har noen gitte egenskaper og ting du liker å gjøre.
// Lag et hovedprogram der hver av deltakerene har sin klasse som
// kan printe ut en introduksjonstekst, og også utføre hver sine hobbyer.

    namespace ParProg1;

    class ParProg1
    {
    static void Main()
    {
    Participant participant1 = new Participant("Stian", "28", "svart", "gamer", "gaming");
    Participant participant2 = new Participant("Mariama", "34", "svart", "koder", "Assassin's creed");
    Console.WriteLine(CommonText(participant1));
    Console.WriteLine(CommonText(participant2));
  }
  public static string CommonText(Participant participant)
  {
  return $"Hei, jeg heter {participant.GetName()}! " + 
  $"Jeg er {participant.GetAge()} år gammel og jeg har {participant.GetHairColor()} hår." +
  $" Se på meg, jeg {participant.GetAtm()}." +
  $"\nNå sitter jeg og gamer litt {participant.GetHobby()}!";
  }
  
  }
  class Participant
  {
  private string _name;
  private string _age;
  private string _hairColor;
  private string _atm;
  private string _hobby;
    
    

  public Participant(string name, string age, string hairColor, string atm, string hobby)
  {
    this._name = name;
    this._age = age;
    this._hairColor = hairColor;
    this._atm = atm;
    this._hobby = hobby;
  }

  public string GetName() { return _name; }
  public string GetAge() { return _age; }
  public string GetHairColor() { return _hairColor; }
  public string GetAtm() { return _atm; }
  public string GetHobby() { return _hobby; }
}


  
