internal class Program
{
    class Animal
    {
        public String name = "I'm animal";
        internal virtual void DoVoice()
        {
            Console.WriteLine(name);
        }
    }

    class Dog : Animal
    {
        public String name = "I'm dog";
        internal override void DoVoice()
        {
            Console.WriteLine(name);
        }
    }

    class Cat : Animal
    {
        public String name = "I'm cat";
        internal override void DoVoice()
        {
            Console.WriteLine(name);
        }
    }

    class Duck : Animal
    {
        public String name = "I'm duck";
        internal override void DoVoice()
        {
            Console.WriteLine(name);
        }
    }

    private static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.DoVoice();
        Console.WriteLine(new String('-', 30));

        Animal animalCat = new Cat();
        Animal animalDog = new Dog();
        Animal animalDuck = new Duck();

        Animal[] ArrayOfAnimals = { animal, animalCat, animalDog, animalDuck };
        for (int i = 0; i < ArrayOfAnimals.Length; i++)
        {
            ArrayOfAnimals[i].DoVoice();
        }
        /* 
         * в настоящих проектах не будут указываться массивы и данные в нем вручную,
         * в них как правило списки с бд, например в EF где через linq приходит список user-ов
         * класса user
         */

        Console.WriteLine(new String('-', 30));

        List<Animal> ListOfAnimals = new List<Animal>
        {
            animal, animalCat, animalDog, animalDuck
        };
        

        for (int i = 0; i < ListOfAnimals.Count; i++)
        {
            ArrayOfAnimals[i].DoVoice();
        }
    }
}