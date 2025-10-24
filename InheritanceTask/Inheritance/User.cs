namespace Task.Inheritance
{
    internal class User
    {
        public string Username;
        public string Password;
        public string Email;

        public User(string username, string password, string email = null)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }
        public bool CheckEmail()
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                return true;
            }
            if (!Email.Contains("@"))
            {
                return false;
            }
            if (!char.IsLetter(Email[0]) && !char.IsLetter(Email[^1]))
            {
                return false;
            }

            return true;
        }
        public bool isValidUsername()
        {
            if (Username.Length >= 6)
            {
                return true;
            }
            return false;
        }
        public bool isValidPassword()
        {
            bool hasUpper = false;
            bool hasDigit = false;
            foreach (char c in Password)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
            }
            return hasDigit && hasUpper;
        }
    }
}
