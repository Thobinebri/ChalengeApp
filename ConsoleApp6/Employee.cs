namespace ConsoleApp6
{

    public class Employee
    {
        public static string Fabryka = "3Com";

        private string password = null;
        private string name;
        //    private int score;
        private List<int> score = new List<int>();
        public string Login { get; private set; }
        public string Name { get; private set; }
        public string lastName { get; private set; }


        public Employee(string login)
        {
            this.Login = login;
        }
        public Employee(string login, string name)
        {
            this.Login = login;
            this.Name = name;
        }
        public Employee(string login, string lastname, int score)
        {
            this.Login = login;
            this.lastName = lastname;
            //        this.score = score;
        }
        public Employee(string login, string name, string lastname)
        {
            this.Login = login;
            this.name = name;
            this.lastName = lastname;
        }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int score)
        {
            this.score.Add(score);
        }


    }
}
