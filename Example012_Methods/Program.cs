﻿// Вид 1
// void Method1()
// {
//     console.WriteLine("Автор ...");
// }
//Method1()

//Вид 2
//void Method2(string msg)
//{
 //   Console.WriteLine(msg);
//}
//  Method2(msg:"Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count:4);

// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int Year = Method3();
// Console.WriteLine(Year);

//Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


