internal class Program
{
    enum Day : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum DayTime : byte
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите день недели и время в формате (1-7) (0-23):");
        string str = Console.ReadLine();

        byte day = Convert.ToByte(str.Split(" ")[0]), time = Convert.ToByte(str.Split(" ")[1]);

        Day now = (Day)day;
        DayTime nowtime = (DayTime)GetTime(time);

        Console.WriteLine($"Now Day: {now}, Time: {nowtime}.");

        byte GetTime(byte time)
        {
            if (time >=7 & time <= 12)
            {
                time = 0;
                return time;
            }
            if (time >= 13 & time <= 18)
            {
                time = 1;
                return time;
            }
            if (time >= 18 & time <= 23)
            {
                time = 2;
                return time;
            }
            else
            {
                time = 3;
                return time;
            }
        }
    }
}