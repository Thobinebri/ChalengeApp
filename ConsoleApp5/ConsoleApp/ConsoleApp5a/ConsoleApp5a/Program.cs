//05.06.2025

//int number = 12111901; 
int number = 123450;
string numberInString = number.ToString();

List<string> cyfry = new List<string>();
int[] ilosc = new int[10];

Console.WriteLine("Liczba do analizy to: " + numberInString);
Console.WriteLine("Ilość znaków to: " + numberInString.Length + " cyfr");

//Analiza ciągu cyfr w liczbie
foreach (char znak in numberInString)
{
    if (znak == '0')
        ilosc[0]++;
    if (znak == '1')
        ilosc[1]++;
    if (znak == '2')
        ilosc[2]++;
    if (znak == '3')
        ilosc[3]++;
    if (znak == '4')
        ilosc[4]++;
    if (znak == '5')
        ilosc[5]++;
    if (znak == '6')
        ilosc[6]++;
    if (znak == '7')
        ilosc[7]++;
    if (znak == '8')
        ilosc[8]++;
    if (znak == '9')
        ilosc[9]++;
}

for (int i = 0; i < 10; i++)
    Console.WriteLine("Ilosc =>" + i + ' ' + ilosc[i]);