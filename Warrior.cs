namespace RolePlayingGame;

class Warrior : Hero
{
    // Public fields should generally be avoided because they break encapsulation,
    // but we're using them here for simplicity.
    public string Weapon;

    public Warrior(string name, int level, string weapon) : base(name, level)
    {
        Weapon = weapon;
    }

    public string Attack()
    {
        return $"{Name} attacks with the {Weapon}.";
    }
}

/*
class Warrior extends Hero {
    weapon;

    constructor(name, level, weapon) {
        super(name, level);
        this.weapon = weapon;
    }

    attack() {
        return `${this.name} attacks with the ${this.weapon}.`;
    }
}
*/