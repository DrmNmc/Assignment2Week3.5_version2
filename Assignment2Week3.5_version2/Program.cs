using System;

namespace NerdStuff
{
    interface ITech
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void TurnOn();
    }

    class Laptop : ITech
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Laptop()
        {
            Brand = "Unknown";
            Model = "Unknown";
        }

        public Laptop(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turning on {Brand} {Model}...");
        }

        public string GetInfo()
        {
            return $"{Brand} {Model}";
        }
    }

    class Program
    {
        static ITech[] baseClassArray = new ITech[10];
        static Laptop[] derivedClassArray = new Laptop[10];
        static int baseClassIndex = 0;
        static int derivedClassIndex = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Base ITech");
                Console.WriteLine("2. Add Derived Laptop");
                Console.WriteLine("3. Change Base ITech");
                Console.WriteLine("4. Change Derived Laptop");
                Console.WriteLine("5. Delete Base ITech");
                Console.WriteLine("6. Delete Derived Laptop");
                Console.WriteLine("7. Display Base ITechs");
                Console.WriteLine("8. Display Derived Laptops");
                Console.WriteLine("9. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBaseITech();
                        break;
                    case 2:
                        AddDerivedLaptop();
                        break;
                    case 3:
                        ChangeBaseITech();
                        break;
                    case 4:
                        ChangeDerivedLaptop();
                        break;
                    case 5:
                        DeleteBaseITech();
                        break;
                    case 6:
                        DeleteDerivedLaptop();
                        break;
                    case 7:
                        DisplayBaseITechs();
                        break;
                    case 8:
                        DisplayDerivedLaptops();
                        break;
                    case 9:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void AddBaseITech()
        {
            Console.Write("Enter ITech brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter ITech model: ");
            string model = Console.ReadLine();

            baseClassArray[baseClassIndex++] = new Laptop(brand, model);
            Console.WriteLine("Base ITech added successfully.");
        }

        static void AddDerivedLaptop()
        {
            Console.Write("Enter Laptop brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter Laptop model: ");
            string model = Console.ReadLine();

            derivedClassArray[derivedClassIndex++] = new Laptop(brand, model);
            Console.WriteLine("Derived Laptop added successfully.");
        }

        static void ChangeBaseITech()
        {
            Console.Write("Enter the index of the Base ITech you want to change: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < baseClassIndex)
            {
                Console.Write("Enter new ITech brand: ");
                string brand = Console.ReadLine();

                Console.Write("Enter new ITech model: ");
                string model = Console.ReadLine();

                baseClassArray[index].Brand = brand;
                baseClassArray[index].Model = model;

                Console.WriteLine("Base ITech changed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void ChangeDerivedLaptop()
        {
            Console.Write("Enter the index of the Derived Laptop you want to change: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < derivedClassIndex)
            {
                Console.Write("Enter new Laptop brand: ");
                string brand = Console.ReadLine();

                Console.Write("Enter new Laptop model: ");
                string model = Console.ReadLine();

                derivedClassArray[index].Brand = brand;
                derivedClassArray[index].Model = model;

                Console.WriteLine("Derived Laptop changed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void DeleteBaseITech()
        {
            Console.Write("Enter the index of the Base ITech you want to delete: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < baseClassIndex)
            {
                for (int i = index; i < baseClassIndex - 1; i++)
                {
                    baseClassArray[i] = baseClassArray[i + 1];
                }

                baseClassIndex--;
                Console.WriteLine("Base ITech deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void DeleteDerivedLaptop()
        {
            Console.Write("Enter the index of the Derived Laptop you want to delete: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < derivedClassIndex)
            {
                for (int i = index; i < derivedClassIndex - 1; i++)
                {
                    derivedClassArray[i] = derivedClassArray[i + 1];
                }

                derivedClassIndex--;
                Console.WriteLine("Derived Laptop deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void DisplayBaseITechs()
        {
            Console.WriteLine("\nBase ITechs:");
            for (int i = 0; i < baseClassIndex; i++)
            {
                Console.WriteLine($"\nBase ITech {i + 1}:");
                baseClassArray[i].TurnOn();
            }
        }

        static void DisplayDerivedLaptops()
        {
            Console.WriteLine("Derived Laptops:");
            for (int i = 0; i < derivedClassIndex; i++)
            {
                Console.WriteLine($"Derived Laptop {i + 1}:");
                derivedClassArray[i].TurnOn();
                Console.WriteLine($"Laptop Model: {derivedClassArray[i].GetInfo()}");
            }
        }
    }
}
