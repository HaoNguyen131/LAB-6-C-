using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Bai3
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int>() { 5, 6, 7, 8, 1 };

        // a) Sử dụng Union cho nguồn dữ liệu và xuất ra màn hình theo giá trị giảm dần
        Console.WriteLine("a) Sử dụng Union:");
        var unionResult = list1.Union(list2).OrderByDescending(x => x);
        Console.WriteLine(string.Join(", ", unionResult));

        // b) Sử dụng Intersect cho nguồn dữ liệu để xuất ra màn hình
        Console.WriteLine("\nb) Sử dụng Intersect:");
        var intersectResult = list1.Intersect(list2);
        Console.WriteLine(string.Join(", ", intersectResult));

        // c) Sử dụng Concat cho nguồn dữ liệu để xuất ra màn hình theo giá trị tăng dần
        Console.WriteLine("\nc) Sử dụng Concat:");
        var concatResult = list1.Concat(list2).OrderBy(x => x);
        Console.WriteLine(string.Join(", ", concatResult));

        // d) Sử dụng Except cho nguồn dữ liệu để xuất ra màn hình
        Console.WriteLine("\nd) Sử dụng Except:");
        var exceptResult = list1.Except(list2);
        Console.WriteLine(string.Join(", ", exceptResult));

        Console.ReadKey();
    }
}