using Tyuiu.VaganovMA.Sprint3.Task2.V25.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #25                                                          *"); 
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич  | ИИПб-24-2                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");


        int value = 5;//n
        int startValue = 1;//k
        int stopValue = 13;
        Console.WriteLine("X:" + value);
        Console.WriteLine("старт шага:" + startValue);
        Console.WriteLine("конец шага:" + stopValue);


        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine($"Ответ = " + ds.GetSumSeries(value, startValue, stopValue));

        Console.ReadKey();
    } 
} 
