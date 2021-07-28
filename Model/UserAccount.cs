namespace LinqBenchmark.Model
{
    public class UserAccount
    {
        public readonly long UserId;

        public readonly string UserName;

        public readonly uint Age;

        public UserAccount(long userId, string userName, uint age)
        {
            UserId = userId;
            UserName = userName;
            Age = age;
        }
    }
}
