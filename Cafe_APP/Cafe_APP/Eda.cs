namespace StudentEventSystem;

    public delegate void StudentEventHandler(string message);

    public class Student
    {

        public event StudentEventHandler LunchTime; 
        public event StudentEventHandler CoffeeTime; 
        private Random random = new Random();

        public void StartDay()
        {
            int Classes = random.Next(2, 6);
            Console.WriteLine($"Начинается учебный день, сегодня у студента {Classes} пары");

            for (int n = 1; n <= Classes; n++)
            {
                Console.WriteLine($"Пара {n}: Студент сидит на паре");

                if (n == 2)
                {
                    LunchTime?.Invoke("После второй пары студент захотел кушать.");
                }


                if (n == 4)
                {
                     CoffeeTime?.Invoke("После четвертой пары студент захотел выпить кофе.");
                }
            }
            Console.WriteLine("Учебный день закончен, студент пошёл спать, ведь завтра снова вставать)");
        }
    }



    public class Cafe
    {
        public void ServeLunch(string message)
        {
            Console.WriteLine($"{message} Кафе приготовило обед");
        }

        public void ServeCoffee(string message)
        {
            Console.WriteLine($"{message} Кафе приготовило кофе");
        }
    }