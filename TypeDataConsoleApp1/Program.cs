namespace TypeDataConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Evlanikov A.S.";
            int age = 23;
            string email = "aleksandr@gmail.com";
            double pointsIt = 4;
            double pointsMaths = 3.8;
            double pointsPhysics = 3.5;

            Console.WriteLine($"ФИО => {fullName}\nВозраст => {age}\nПочта => {email}\n" +
                $"Баллы по програмирыванию => {pointsIt}\nБаллы по математике => {pointsMaths}\n" +
                $"Баллы по физике => {pointsPhysics}");

            Console.ReadKey();

            double averagePoints = (pointsIt + pointsMaths + pointsPhysics) / 3;

            Console.WriteLine();
            Console.WriteLine($"Средний балл по предметам равен: {averagePoints}");

        }
    }
}
