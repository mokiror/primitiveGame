using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWonE
{
    enum WeekDays
    {
        monday = 1,
        tuseday, 
        wednesday,
        thursday,
        friday,
        saturday,
        sunday 
    }

    enum Power
    {
        rabbit = 1,
        wolf = 2,
        bear = 3
    }

    enum Speed
    {
        turtle = 1,
        dog = 2,
        cheetos = 3
    }

    enum Armor
    {
        paper = 1,
        wood = 2,
        steel = 3
    }

    enum Fortune
    {
        misfortune = 1,
        normal = 2,
        lucky = 3
    }

    struct Person
    {
        public int id; //в с++ он всё время паблик
        public string name;
        public Power power;
        public Speed speed;
        public Armor armor;
        public Fortune fortune;
        public Person(int _id, string _name, 
            Power _power, Speed _speed, Armor _armor, Fortune _fortune)
        {
            id = _id;
            name = _name;
            power = _power;
            speed = _speed;
            armor = _armor;
            fortune = _fortune;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int _power = (int)Power.wolf;
            Person Stark = new Person();
            Person Snow = new Person();

            Snow = new Person(7, "Snow", Power.wolf, Speed.dog, Armor.steel, Fortune.normal);
            //Stark = new Person(8, "Stark", Enum.GetValues(typeof(Power))[_power], Speed.cheetos, Armor.wood, Fortune.misfortune);


            Console.WriteLine("Дни недели: ");
            for (int i = (int)WeekDays.monday; i < (int)WeekDays.sunday; i++) 
            {
                Console.WriteLine(i); //числа
                Console.WriteLine(Enum.GetNames(typeof(WeekDays))[i]); //дни недели
            }
            
            //вывод через название
            Console.WriteLine(WeekDays.friday);

            Console.WriteLine("\n");

            //HOMUNCULUS

            Person Homunculus = new Person();
            Console.WriteLine("\n\nHOMUNCULUS FACTORY\n");
            int counter = 0;

            //power
            Console.WriteLine("Выберите количество силы (до 7): ");
            string choose;
            Console.WriteLine($"1 - {Power.rabbit}");
            Console.WriteLine($"2 - {Power.wolf}");
            Console.WriteLine($"3 - {Power.bear}");
            choose = Console.ReadLine();
            Homunculus.id = 11;

            if (int.Parse(choose) == 1)
            {
                Console.WriteLine($"Вы выбрали: {Power.rabbit}");
            
                Homunculus.power = (Power.rabbit);
                counter += 1;

                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                    
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");
                    
                }
            }
            else if (int.Parse(choose) == 2)
            {
                Console.WriteLine($"Вы выбрали: {Power.wolf}");

                Homunculus.power = (Power.wolf);
                counter += 2;
                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            else if (int.Parse(choose) == 3)
            {
                Console.WriteLine($"Вы выбрали: {Power.bear}");
                Homunculus.power = (Power.bear);
                counter += 3;

                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            Console.WriteLine(counter);

            //speed
            Console.WriteLine("Выберите скорость (до 7): ");
            string choose2;
            Console.WriteLine($"1 - {Speed.turtle}");
            Console.WriteLine($"2 - {Speed.dog}");
            Console.WriteLine($"3 - {Speed.cheetos}");
            choose2 = Console.ReadLine();

            if (int.Parse(choose2) == 1)
            {
                Console.WriteLine($"Вы выбрали: {Speed.turtle}");
                Homunculus.speed = (Speed.turtle);
                counter += 1;

                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            else if (int.Parse(choose2) == 2)
            {
                Console.WriteLine($"Вы выбрали: {Speed.dog}");
                Homunculus.speed = (Speed.dog);
                counter += 2;

                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            else if (int.Parse(choose2) == 3)
            {
                Console.WriteLine($"Вы выбрали: {Speed.cheetos}");
                Homunculus.speed = (Speed.dog);
                counter += 3;
                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            Console.WriteLine(counter);

            //Armor
            Console.WriteLine("Выберите броню (до 7): ");
            string choose3;
            Console.WriteLine($"1 - {Armor.paper}");
            Console.WriteLine($"2 - {Armor.wood}");
            Console.WriteLine($"3 - {Armor.paper}");
            choose3 = Console.ReadLine();

            if (int.Parse(choose3) == 1)
            {
                Console.WriteLine($"Вы выбрали: {Armor.paper}");
                Homunculus.armor = (Armor.paper);
                counter += 1;

                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            else if (int.Parse(choose3) == 2)
            {
                Console.WriteLine($"Вы выбрали: {Armor.wood}");
                Homunculus.armor = (Armor.wood);
                counter += 2;

                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            else if (int.Parse(choose3) == 3)
            {
                Console.WriteLine($"Вы выбрали: {Armor.steel}");
                Homunculus.armor = (Armor.steel);
                counter += 3;
                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            Console.WriteLine(counter);

            //Fortune
            Console.WriteLine("Выберите удачу (до 7): ");
            string choose4;
            Console.WriteLine($"1 - {Fortune.misfortune}");
            Console.WriteLine($"2 - {Fortune.normal}");
            Console.WriteLine($"3 - {Fortune.lucky}");
            choose4 = Console.ReadLine();

            if (int.Parse(choose4) == 1)
            {
                Console.WriteLine($"Вы выбрали: {Fortune.misfortune}");
                Homunculus.fortune = (Fortune.misfortune);
                counter += 1;

                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            else if (int.Parse(choose4) == 2)
            {
                Console.WriteLine($"Вы выбрали: {Fortune.normal}");
                Homunculus.fortune = (Fortune.normal);
                counter += 2;

                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            else if (int.Parse(choose4) == 3)
            {
                Console.WriteLine($"Вы выбрали: {Fortune.lucky}");
                Homunculus.fortune = (Fortune.lucky);
                counter += 3;
                if (counter <= 7)
                {
                    Console.WriteLine("вы в диапазоне");
                }
                else
                {
                    Console.WriteLine("выберите другой параметр силы");

                }
            }
            Console.WriteLine(counter);

            Console.WriteLine("\n\n");
            Console.WriteLine("Ваш супер крутой перс: ");
            Console.WriteLine($"Имя: хомункулус, Id: {Homunculus.id}, \nсила - {Homunculus.power}, скорость -  {Homunculus.speed}, " +
                $"\nброня - {Homunculus.armor}, удача - {Homunculus.fortune}");
            Console.WriteLine($"Всего кол-во очков: {counter}"); 

            Console.ReadKey();
        }
    }
}
