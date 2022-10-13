using System.Diagnostics;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
string binaryconversion()
{
    Console.WriteLine("Enter the number in decimal");
    string input = Console.ReadLine();
    int newinput = Convert.ToInt32(input);
    int temp1 = newinput;
    List<int> list = new List<int>();
    while (temp1 > 0)
    {
        if (temp1 % 2 == 1)
        {
            temp1 = temp1 / 2;
            Console.WriteLine("1");
            list.Add(1);
        }
        else
        {
            temp1 = temp1 / 2;
            list.Add(0);
            Console.WriteLine("0");
        }
    }
    
    string result = string.Join("", list);
    return (result);
}

Console.WriteLine(binaryconversion());