using System.Diagnostics;

 int Task1()
{
    Console.WriteLine("Enter a whole number");
    string number1 = Console.ReadLine();
    int num1 = Convert.ToInt32(number1);
    Console.WriteLine("Enter another whole number");
    string number2 = Console.ReadLine();
    int num2 = Convert.ToInt32(number2);
    int temp1 = num1;
    int temp2 = num2;
    while (temp1 != temp2)
    {
        if (temp1 > temp2)
        {
            temp1 = temp1 - temp2;
        }
        else
        {
            temp2 = temp2 - temp1;
        }
    }
    int result = temp1;
    return (result);
}

Console.WriteLine(Task1());
// the while loop was written using temp1 and temp2 so that the original numbers are not altered