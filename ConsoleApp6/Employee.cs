namespace ConsoleApp6
{

    public class Employee
    {
        public static string Company = "3Com";
        private string Name;
        private string Surname;
        private int Age;
        private List<int> Score = new List<int>();



        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public int Result
        {
            get
            {
                return this.Score.Sum();
            }
        }
        public int age
        {
            get
            {
                return this.Age;
            }
        }
 
        public string name
        {
            set { Name = name; }
            get
            {
                return Name;
            }
        }
        public string surname
        {
            get
            {
                return Surname;
            }
        }

        public void AddScore(int score)
        {
            this.Score.Add(score);
        }


    }
}
