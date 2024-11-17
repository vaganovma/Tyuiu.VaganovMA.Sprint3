using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.VaganovMA.Sprint3.Task3.V21.Lib;

public class DataService : ISprint3Task3V21
{
    public string ReplaceNumOnChar(string value, char item)
    {
        string res = value;
        //double count = 0;
        foreach (char c in value)
        {
            if (c == item)
            {
                count++;
            }
        }
        return count;
    }
} 
