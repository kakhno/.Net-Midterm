namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // task 1
            int temperature = 10;

            string city = "tbilisi";

            for (int i = 1; i <= 7; i++) 
            {
                Console.WriteLine($"{city} --- {i} --- {(temperature*9/5) + 32}");
            }

            //task 2 
            Console.WriteLine();

            Student student = new Student("Cotne", 3);
            Console.WriteLine(student.Greeting());

            //task 3

            Console.WriteLine();

            Triangle triangle = new Triangle(5, 7);
            Square square = new Square(5);

            Console.WriteLine(triangle.CalculateArea(5,7));
            Console.WriteLine(square.CalculateArea(5));


            //task 4
            Console.WriteLine();

            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine(dog.MakeSound());
            Console.WriteLine(cat.MakeSound());



            //task 5
            Console.WriteLine();

            MyCollection<string> myList = new MyCollection<string>();
            myList.AddItem("Mercedes");
            myList.AddItem("Bmw");
            myList.AddItem("Audi");
            myList.AddItem("Porche");

            Console.WriteLine(myList.GetItem(1));

        }
    }
}
