namespace RolePlayingGame;

class Program
{
    static void Main(string[] args)
    {
        var warrior = new Warrior("Bjorn", 1, "axe");
        Console.WriteLine(warrior.Greet());

        var healer = new Healer("Kanin", 1, "cure");
        Console.WriteLine(healer.Greet());

        Console.WriteLine(warrior.Attack());
        Console.WriteLine(healer.Heal());
    }
}
