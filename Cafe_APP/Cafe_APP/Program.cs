namespace StudentEventSystem;
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        Cafe cafe = new Cafe();

        student.LunchTime += cafe.ServeLunch;         
        student.CoffeeTime += cafe.ServeCoffee;       

        student.LunchTime += (message) => Console.WriteLine($"Студент зашёл в кафе на обед");
        student.CoffeeTime += (message) => Console.WriteLine($"Студент зашёл в кафе за кофе");

        student.StartDay();

    }
}

