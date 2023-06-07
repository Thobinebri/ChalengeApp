using ConsoleApp6;

var user1 = new Employee("Lukasz", "Matura", 1);
var user2 = new Employee("Adam", "Kowalski", 15);
var user3 = new Employee("Ewa", "Nowak", 3);
//Console.Write(user1.name + " " + user1.lastName + " 1 ");
user1.AddScore(5);
user1.AddScore(6);
Console.Write(user1.Result + " 1 ");
Console.WriteLine(Employee.Fabryka);




//Testy
//Console.WriteLine(user1.login+" 1 "+ user1.ToString);
