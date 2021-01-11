using System.ComponentModel.DataAnnotations;

namespace ProjectBug.Helpers
{
    public class User
    {
        [Key] public string username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}