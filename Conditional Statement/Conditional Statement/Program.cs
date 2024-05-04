// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conditional Statement");


Console.WriteLine("If else");
start:

Console.WriteLine("Enter Your Username");
string username = Console.ReadLine();
Console.WriteLine("Enter Your Password");
int password = int.Parse(Console.ReadLine());

if (username == "sarfaraz" && password == 1234)
{
    Console.WriteLine("Login Successfull");
}
else
{
    Console.WriteLine("Login Failed!");
    goto start;
}