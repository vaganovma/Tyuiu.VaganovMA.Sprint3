using Tyuiu.VaganovMA.Sprint3.Task1.V23.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #1                                                           *"); 
        Console.WriteLine("* Вариант #23                                                          *"); 
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич  | ИИПб-24-2                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");


        int value = 5;
        int startValue = 1;
        int stopValue = 5;
        Console.WriteLine("X:" + value);
        Console.WriteLine("старт шага:" + startValue);
        Console.WriteLine("конец шага:" + stopValue);


        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine($"Ответ = " + ds.GetMultiplySeries(value, startValue, stopValue));

        Console.ReadKey();
    } 
} 
