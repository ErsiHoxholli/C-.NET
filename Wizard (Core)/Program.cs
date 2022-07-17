public class Human
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }



    public Human(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }

    // Build Attack method
    public virtual int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
}

public class Wizard : Human
{

    public Wizard(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)
    {
        Name = name;
        Strength = str;
        Intelligence = 25;
        Dexterity = dex;
        Health = 50;
    }

    public override int Attack(Human target)
    {

        int dmg = Intelligence * 5;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;

    }

    public void Heal(Human target)
    {

        int heal = Intelligence * 10;
        target.Health += heal;

    }

}

public class Ninja : Human
{

    public Ninja(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = 175;
        Health = hp;
    }


    public override int Attack(Human target)
    {

        int dmg = Dexterity * 5;
        target.Health -= dmg;
        Health += dmg;
        Random rnd = new Random();
        int rand = rnd.Next(0, 5);
        if (rand == 0)
        {
            target.Health -= 10;
            Console.WriteLine($"{Name} dealed {target.Name} 10 more damage!");
            Console.WriteLine($"{Name} attacked {target.Name} for {(dmg + 10)} damage!");

        }
        else
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;

    }

    public void Steal(Human target)
    {
        target.Health -= 5;
        Health += 5;

    }

}

public class Samurai : Human
{


    public Samurai(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = 200;
    }

    public override int Attack(Human target)
    {
        base.Attack(target);
        if (target.Health < 50)
            target.Health = 0;
        return target.Health;


    }

    public void Meditate()
    {
        Health = 200;
    }


}

class program
{
    static void Main(string[] args)
    {
        Human human1 = new Human("ilgi", 100, 10, 100, 10);
        Wizard wizard1 = new Wizard("ilgi waizard1", 200, 20, 200, 100);
        Wizard wizard2 = new Wizard("ilgi waizard2", 200, 20, 200, 100);
        Samurai samurai1 = new Samurai("ilgi samurai", 30, 300, 300, 30);
        Ninja ninja1 = new Ninja("ilgi ninja1", 100, 10, 10, 100);
        Ninja ninja2 = new Ninja("ilgi ninja2", 100, 10, 10, 150);

        Console.WriteLine(wizard1.Name + " " + wizard1.Intelligence + " " + wizard1.Health);
        Console.WriteLine(samurai1.Name + " " + samurai1.Health);
        Console.WriteLine(ninja1.Name + " " + ninja1.Dexterity);

        Console.WriteLine(wizard1.Name + " health " + wizard1.Health);
        Console.WriteLine(samurai1.Name + " health " + samurai1.Health);

        wizard1.Attack(samurai1);
        Console.WriteLine(wizard1.Name + " health " + wizard1.Health);
        Console.WriteLine(samurai1.Name + " health " + samurai1.Health);

        wizard1.Heal(samurai1);
        Console.WriteLine(samurai1.Name + " health " + samurai1.Health);

        Console.WriteLine(ninja1.Name + " health " + ninja1.Health);
        samurai1.Attack(ninja1);
        Console.WriteLine(ninja1.Name + " health " + ninja1.Health);

        Console.WriteLine(ninja2.Name + " health " + ninja2.Health);
        samurai1.Attack(ninja2);
        Console.WriteLine(ninja2.Name + " health " + ninja2.Health);


        wizard1.Attack(samurai1);
        Console.WriteLine(samurai1.Name + " health " + samurai1.Health);
        samurai1.Meditate();
        Console.WriteLine(samurai1.Name + " health " + samurai1.Health);

        Console.WriteLine(wizard1.Name + " health " + wizard1.Health);
        Console.WriteLine(ninja1.Name + " health " + ninja1.Health);
        ninja1.Attack(wizard1);
        Console.WriteLine(wizard1.Name + " health " + wizard1.Health);
        Console.WriteLine(ninja1.Name + " health " + ninja1.Health);

        Console.WriteLine(wizard2.Name + " health " + wizard2.Health);
        Console.WriteLine(ninja2.Name + " health " + ninja2.Health);
        ninja2.Attack(wizard2);
        Console.WriteLine(wizard2.Name + " health " + wizard2.Health);
        Console.WriteLine(ninja2.Name + " health " + ninja2.Health);

        Console.WriteLine(wizard1.Name + " health " + wizard1.Health);
        Console.WriteLine(ninja1.Name + " health " + ninja1.Health);
        ninja1.Steal(wizard1);
        Console.WriteLine(wizard1.Name + " health " + wizard1.Health);
        Console.WriteLine(ninja1.Name + " health " + ninja1.Health);




    }
}
