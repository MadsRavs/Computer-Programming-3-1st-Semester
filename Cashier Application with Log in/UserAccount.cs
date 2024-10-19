namespace UserAccountNamespace
{
    public class UserAccount
    {
        protected string username;
        protected string password;

        public UserAccount(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public virtual bool ValidateCredentials(string inputUsername, string inputPassword)
        {
            return this.username == inputUsername && this.password == inputPassword;
        }
    }

    public class Cashier : UserAccount
    {
        public string fullName;
        public string department;

        public Cashier(string username, string password, string fullName, string department)
            : base(username, password)
        {
            this.fullName = fullName;
            this.department = department;
        }

        public override bool ValidateCredentials(string inputUsername, string inputPassword)
        {
            return base.ValidateCredentials(inputUsername, inputPassword);
        }
    }
}
