namespace RolePlayingGame;

class Healer : Hero {
  // Public fields should generally be avoided because they break encapsulation,
  // but we're using them here for simplicity.
  public string Spell;

  public Healer(string name, int level, string spell) : base(name, level)
  {
    Spell = spell;
  }

  public string Heal()
  {
    return $"{Name} casts {Spell}.";
  }
}