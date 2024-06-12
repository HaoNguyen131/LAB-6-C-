using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<int> listInt = new List<int>() { 2, 4, 5, 6, 7, 8, 9 };
        List<string> listStr = new List<string>() { null, "T1", "T2", "T3", null };
        List<string> listNull = new List<string>();

        // a/ Tìm số chẵn đầu tiên và lớn hơn 5 trong listInt
        int firstEvenNumberGreaterThan5 = listInt.FirstOrDefault(x => x % 2 == 0 && x > 5);
        Console.WriteLine($"a/ Số chẵn đầu tiên lớn hơn 5: {firstEvenNumberGreaterThan5}");

        // b/ Tìm phần tử cuối cùng trong listInt có giá trị > 200
        int lastElementGreaterThan200 = listInt.LastOrDefault(x => x > 200);
        Console.WriteLine($"b/ Phần tử cuối cùng lớn hơn 200: {lastElementGreaterThan200}");

        // c/ Tìm phần tử đầu tiên trong listStr có giá trị bắt đầu bằng ký tự “T”
        string firstElementStartsWithT = listStr.FirstOrDefault(x => x != null && x.StartsWith("T"));
        Console.WriteLine($"c/ Phần tử đầu tiên bắt đầu bằng ký tự 'T': {firstElementStartsWithT}");

        // d/ Tính tổng các trị tại vị trí index lẻ và số đó chia hết cho 2 trong listInt
        int sumOfOddIndexElementsDivisibleBy2 = listInt.Where((x, index) => index % 2 != 0 && x % 2 == 0).Sum();
        Console.WriteLine($"d/ Tổng các trị tại vị trí index lẻ và số đó chia hết cho 2: {sumOfOddIndexElementsDivisibleBy2}");

        Console.ReadKey();
    }
}