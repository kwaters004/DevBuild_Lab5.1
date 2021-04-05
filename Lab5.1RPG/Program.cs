using System;
using System.Collections.Generic;

namespace Lab5._1RPG
{

    class GameCharacter
    {

        private string name;
        private int strength;
        private int intelligence;

        public GameCharacter(string aName, int aStrength, int aIntelligence)
        {
            Name = aName;
            Strength = aStrength;
            Intelligence = aIntelligence;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }



        public virtual void Play()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine($"Intelligence: {intelligence}\n");
        }




    }

    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;

        public int MagicalEnergy
        {
            get { return magicalEnergy; }
            set { magicalEnergy = value; }
        }

        public MagicUsingCharacter(string aName, int aStrength, int aIntelligence, int aMagicalEnergy) : base(aName, aStrength, aIntelligence)
        {
            Name = aName;
            Strength = aStrength;
            Intelligence = aIntelligence;
            MagicalEnergy = aMagicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Magical Energy: {magicalEnergy}\n");
        }


    }

    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public Wizard(string aName, int aStrength, int aIntelligence, int aMagicalEnergy, int aSpellNumber) : base(aName, aStrength, aIntelligence, aMagicalEnergy)
        {
            Name = aName;
            Strength = aStrength;
            Intelligence = aIntelligence;
            MagicalEnergy = aMagicalEnergy;
            SpellNumber = aSpellNumber;
        }


        public override void Play()
        {
            Console.WriteLine($"{Name} the Wizard (int {Intelligence}, strength {Strength}, magic {MagicalEnergy}) {SpellNumber} spells");
        }

        public int SpellNumber
        {
            get { return spellNumber; }
            set { spellNumber = value; }
        }

    }

    class Warrior : GameCharacter
    {
        public string weaponType;

        public Warrior(string aName, int aStrength, int aIntelligence, string aWeaponType) : base(aName, aStrength, aIntelligence)
        {
            Name = aName;
            Strength = aStrength;
            Intelligence = aIntelligence;
            WeaponType = aWeaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} the Warrior (int {Intelligence}, strength {Strength}) {weaponType}");
        }

        public string WeaponType
        {
            get { return weaponType; }
            set { weaponType = value; }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to World of Dev.Buildcraft!\n");

            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            gameCharacters.Add(new Wizard("Dumbledore", 5, 20, 100, 50));
            gameCharacters.Add(new Wizard("Gandalf", 15, 35, 500, 1000));
            gameCharacters.Add(new Wizard("Harry Potter", 10, 2, 50, 1));
            gameCharacters.Add(new Warrior("Conan", 50, 5, "Morningstar"));
            gameCharacters.Add(new Warrior("Aragorn", 25, 15, "Sword"));

            foreach (GameCharacter character in gameCharacters)
            {
                character.Play();
            }
            Console.WriteLine();

        }
    }
}
