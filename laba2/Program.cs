using System;

class Program
{
    enum DayOfWeek
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    enum TimeOfDay
    {
        Утро,
        День,
        Вечер,
        Ночь
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите день недели:");
        string dayInput = Console.ReadLine();
        DayOfWeek day;
        if (!Enum.TryParse(dayInput, true, out day) || !Enum.IsDefined(typeof(DayOfWeek), day))
        {
            Console.WriteLine("Ошибка: Неверно введен день недели.");
            return;
        }

        Console.WriteLine("Введите время:");
        int timeInput;
        if (!int.TryParse(Console.ReadLine(), out timeInput) || timeInput < 0 || timeInput > 23)
        {
            Console.WriteLine("Ошибка: Неверно введено время.");
            return;
        }
        TimeOfDay timeOfDay = GetTimeOfDay(timeInput);

        Console.WriteLine($"Сейчас {day}, {timeOfDay}");
    }

    static TimeOfDay GetTimeOfDay(int time)
    {
        if (time >= 7 && time <= 12)
        {
            return TimeOfDay.Утро;
        }
        else if (time >= 13 && time <= 18)
        {
            return TimeOfDay.День;
        }
        else if (time >= 19 && time <= 23)
        {
            return TimeOfDay.Вечер;
        }
        else
        {
            return TimeOfDay.Ночь;
        }
    }
}