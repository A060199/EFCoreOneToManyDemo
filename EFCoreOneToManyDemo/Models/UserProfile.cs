namespace EFCoreOneToManyDemo.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
