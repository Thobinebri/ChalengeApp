using Test;
using System.Diagnostics;

var user1 = new Employee("Lukasz", "Matura", 25);
var user2 = new Employee("Adam", "Kowalski", 30);
var user3 = new Employee("Ewa", "Nowak", 39);
List<Employee> lista = new List<Employee>();
List<int> TheBest = new List<int>();
lista.Add(user1);
lista.Add(user2);
lista.Add(user3);

user1.AddScore(10);
user1.AddScore(4);
user1.AddScore(0);
user1.AddScore(5);
user1.AddScore(6);

user2.AddScore(4);
user2.AddScore(7);
user2.AddScore(4);
user2.AddScore(0);
user2.AddScore(7);

user3.AddScore(8);
user3.AddScore(4);
user3.AddScore(8);
user3.AddScore(5);
user3.AddScore(8);

Console.WriteLine("Nazwa firmy: " + Employee.Company);
int i = 0;
int iMax = 0;
int scoreMax = 0;

foreach (var employee in lista)
{
    Console.Write(lista[i].Name + " ");
    Console.Write(lista[i].Surname);
    Console.Write(" Wiek: " + lista[i].Age);
    Console.WriteLine(" Score: " + lista[i].Result);
    TheBest.Add(lista[i].Result);
    if (lista[i].Result > scoreMax)
    {
        iMax = i;
        scoreMax = lista[i].Result;
    }
    ++i;
}
Console.Write("Najlepszy to: " + lista[iMax].Name + " " + lista[iMax].Surname + " wiek:" + lista[iMax].Age);
Console.WriteLine(", a wynik to: " + scoreMax);


//Testy
/*
Boolean zakres = false;
Boolean dodaj = true;
while (dodaj == true)
{
    while (zakres == false)
    {
        Console.WriteLine("Dodaj imię pracownika. q - zakończ dodawanie");
        if (Console.ReadLine() == "q")
            dodaj = false; break;
        int a = Int32.Parse(Console.ReadLine());


        if (a < 0 || a > 10)
            Console.WriteLine("Ocena musi być z zakresu 0-10");
        else
            zakres = true;

    }
}
*/


//Console.WriteLine(user1.login+" 1 "+ user1.ToString);
//Console.Write(user1.name + " " + user1.lastName + " 1 ");

//int a = 23;
//string b;

//b = Console.ReadLine();
//a = Int32.Parse(b);
//Console.WriteLine(b);