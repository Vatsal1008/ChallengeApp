namespace ChallengeApp
{
    public class User
    {
        private List<int> score = new List<int>();
        private string login;
        private string password;
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;

        }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
