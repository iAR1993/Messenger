using System.Data.Entity;

namespace MessengerServiceWebRole.Database.Context.Entities
{
    public class UserContext : DbContext
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}