using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.VaganovMA.Sprint3.Task7.V24.Lib;

public class DataService : ISprint3Task7V24
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {       
        double[] valueArray;  //��������� ������ ������
        int len = (stopValue - startValue) + 1;    // ��������� ������ �������    
        valueArray = new double[len];//������� ������ � ��������� �������
        double y;
        int count = 0;
        for (int x = startValue; x <= stopValue; x++)
            {
            double z = (Math.Sin(x) / (x + 1.2)) - Math.Sin(x) * 2 - 2 * x;
            y = Math.Round(z, 2);//���������
            valueArray[count] = y;//����������� �������� � ������ � �������� �����
            count++;
        }
        return valueArray;
    }
} 
