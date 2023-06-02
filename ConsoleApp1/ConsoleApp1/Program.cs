//Dane: Deklaracje imion, płci, wieku.

string ManName = "Adam";
string WomenName = "Ewa";

string aMan = "Mężczyzna";
string aWoman = "Kobieta";
int underAge = 18;
int braeakAge = 33;

//Zadane wartości do wyszukania i opisania:
//Pełnoletniość i płeć. Jeśli 33 lata to również imie
bool isMan = false;
int age = 35;

//Zmienna robocza-wynik
string tempAnswer = null;

if (age < underAge)
    if (isMan)
        tempAnswer = "Niepełnoletni " + aMan;
    else
        tempAnswer = "Niepełnoletnia " + aWoman;
if (age >= underAge && age < braeakAge)
{
    if (isMan)
        tempAnswer = aMan + ", lat " + age;
    else
        tempAnswer = aWoman + ", lat " + age;
}

if (age >= braeakAge)
{
    if (isMan)
        tempAnswer = ManName + ", lat " + age;
    else
        tempAnswer = WomenName + ", lat " + age;
}


/*
else if (!isMan)
tempAnswer = aWoman;
else
tempAnswer = aMan;
 */



Console.WriteLine(tempAnswer);