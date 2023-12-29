// Zadanie domowe dzień 7.
namespace ChallangeApp
{
    public class User
    {
        private List<int> score = new List<int>();


        public User(string name, string surename, int age)
        {
            this.name = name;
            this.surename = surename;
            this.age = age;
        }

        public string name { get; private set; }

        public string surename { get; private set; }

        public int age { get; private set; }

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