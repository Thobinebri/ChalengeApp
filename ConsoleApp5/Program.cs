using System.Diagnostics;
using System.Linq;

//Dane: Deklaracje liczby do analizy.
int number = 12111901;
string iString = "";
string numberInString = number.ToString();

List<string> cyfry = new List<string>();
char[] letters = numberInString.ToArray();
int[] ilosc = new int[10];

//Tablica cyfr od 0 do 9 jako string
for (int i = 0; i < 10; i++)
    cyfry.Add(iString);

Console.WriteLine("Liczba do analizy to: " + numberInString);
Console.WriteLine("Ilość znaków to: " + letters.Length + " cyfr");

//Analiza ciągu cyfr w liczbie
for (int i = 0; i < letters.Length; i++)
{
    if (numberInString[i] == '0')
        ilosc[0]++;
    if (numberInString[i] == '1')
        ilosc[1]++;
    if (numberInString[i] == '2')
        ilosc[2]++;
    if (numberInString[i] == '3')
        ilosc[3]++;
    if (numberInString[i] == '4')
        ilosc[4]++;
    if (numberInString[i] == '5')
        ilosc[5]++;
    if (numberInString[i] == '6')
        ilosc[6]++;
    if (numberInString[i] == '7')
        ilosc[7]++;
    if (numberInString[i] == '8')
        ilosc[8]++;
    if (numberInString[i] == '9')
        ilosc[9]++;
}

for (int i = 0; i < 10; i++)
    Console.WriteLine("Ilosc =>" + i + ' ' + ilosc[i]);



//Testy

//Console.WriteLine("Cyfra x "+numberInString[3]);
//Console.WriteLine(letters[0]);

//foreach (var cyfra in cyfry)
//  Console.WriteLine(cyfra + " foreach");

//foreach (var cyfra in cyfry)

//    iString = i.ToString();

//string numberInString = ToString(number);
//List<char> cyfry = new List<char>();


//cyfry.Add("a");

//letters = number.ToArray(number);

//numberInString = cyfry.ToString(number);
//Console.WriteLine(numberInString);

//for (int i = 0; i < 3; i++)
//Console.WriteLine(cyfry[i] + " for");

class User
{
    string name;
    string surname;
}
