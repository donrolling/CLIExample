namespace iStradaCli.Models
{
    public class UserProfile
    {
        public UserProfile()
        {
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool Staging { get; set; }
        public string OutputFormat { get; set; }
    }
}