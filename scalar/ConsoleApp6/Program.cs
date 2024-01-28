using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)

    {
        Add(5, 10);
    }

    private static void Add(int x, int y)
    {
        int answer = x + y;
        Console.WriteLine("{0}+{1}={2}", x, y, answer);
    }
}






