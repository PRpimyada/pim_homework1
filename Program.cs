using System;
/*class Program {
static void Main(string[] args) {
Console.Write("Enter password (6 digits) : ");
int password = int.Parse(Console.ReadLine());
int one_hundred_thousand = password/100000;
password = password - one_hundred_thousand * 100000;
int ten_thousand = password/10000;
password = password - ten_thousand * 10000;
int one_thousand = password/1000;
password = password - one_thousand * 1000;
int one_hundred = password/100;
password = password - one_hundred * 100;
int ten = password/10;
password = password - ten * 10;
int one = password/1 ;
password = password - one * 1;    
Console.Write("Enter agency (FBI, CIA, NSA) : ");
string agency = Console.ReadLine().ToUpper();
switch (agency) {
case "FBI": 
    if ((one_hundred_thousand >= 4 && one_hundred_thousand <= 7) && (one_hundred % 2 == 0 && one_hundred != 6) && (ten_thousand % 2 != 0))
        {Console.WriteLine("True");} else {Console.WriteLine("False");}
break;
case "CIA":
    if (one % 3 == 0 && ten != 1 && ten != 3 && ten != 5 && one_thousand >= 6 && one_thousand != 8 )
        {Console.WriteLine("True");} else {Console.WriteLine("False");}
break;
case "NSA":
    if (30 % one == 0 && one_hundred % 3 == 0 && one_hundred % 2 != 0 && (ten == 7 || one_thousand ==7 || ten_thousand == 7 || one_hundred_thousand == 7))
        {Console.WriteLine("True");} else {Console.WriteLine("False");}
break;
default:
Console.WriteLine("False");
break;
}
}
}*/
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter your password (6 digits)");
        int p = int.Parse(Console.ReadLine());
        int _100K = p / 100000, _10K = p / 10000 % 10, _1K = p / 1000 % 10, _100 = p / 100 % 10, _10 = p / 10 % 10, _1 = p % 10;
        Console.WriteLine("Enter your agency name (FBI, CIA, NSA)");
        string agency = Console.ReadLine().ToUpper();
        bool c = false;
        if (agency == "CIA" && _1 % 3 == 0 && _10 != 1 && _10 != 3 && _10 != 5 && _1K >= 6 && _1K != 8) {
        c = true;
        } else if (agency == "FBI" && _100K >= 4 && _100K <= 7 && _100 % 2 == 0 && _100 != 6 && _10K % 2 != 0) {
        c = true;
        } else if (agency == "NSA" && 30 % _1 == 0 && _100 % 3 == 0 && _100 % 2 != 0 && (_10 == 7 || _1K == 7 || _10K == 7 || _100K == 7)) {
        c = true;
        }
        Console.WriteLine(c ? "True" : "False");
    }
}