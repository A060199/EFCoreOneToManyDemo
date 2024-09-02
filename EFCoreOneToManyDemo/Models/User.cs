namespace EFCoreOneToManyDemo.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public UserProfile Profile { get; set; }
    }
}
