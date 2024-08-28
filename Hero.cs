namespace RolePlayingGame;

class Hero
{
  // Public fields should generally be avoided because they break encapsulation,
  // but we're using them here for simplicity.
  public string Name;
  public int Level;

  public Hero(string name, int level)
  {
    Name = name;
    Level = level;
  }

  public string Greet()
  {
    return $"{Name} says hello.";
  }
}

/*
class Hero {
  name;
  level;

  constructor(name, level) {
    this.name = name;
    this.level = level;
  }

  greet() {
    return `${this.name} says hello.`;
  }
}
*/
