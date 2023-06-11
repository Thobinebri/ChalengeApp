namespace ConsoleApp6
{
    public class Employee
    {
        public static string Company = "3Com";

        private List<int> Score = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public int Age { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Result
        {
            get
            {
                return this.Score.Sum();
            }
        }
        public void AddScore(int score)
        {
            this.Score.Add(score);
        }


    }
}
