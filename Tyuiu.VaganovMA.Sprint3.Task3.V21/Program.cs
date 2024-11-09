using Tyuiu.VaganovMA.Sprint3.Task3.V21.Lib; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Ваганов. М. А. | ИИПб-24-2"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #3                                                           *"); 
        Console.WriteLine("* Вариант #21                                                          *"); 
        Console.WriteLine("* Выполнил: Ваганов Михаил Алексеевич  | ИИПб-24-2                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");

        Console.WriteLine(" f3g5ht g4j 34kg4 ");

        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");


        string str = "f3g5ht g4j 34kg4"; foreach (char c in str)
            {
                if (c == '3')
                {
                    str = str.Replace(c, 'e');
                }
            }
           
            foreach (char c in str)
            {
                if (c == '4')
                {
                    str = str.Replace(c, 'e');
                }
            }
            
            foreach (char c in str)
            {
                if (c == '5')
                {
                    str = str.Replace(c, 'e');
                }
            }
            Console.WriteLine(str);
                
    } 
} 
