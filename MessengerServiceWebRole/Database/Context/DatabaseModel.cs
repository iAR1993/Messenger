using MessengerServiceWebRole.Database.Context.Entities;

namespace MessengerServiceWebRole.Database.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DatabaseModel : DbContext
    {
        public DatabaseModel() : base("name=DatabaseModel")
        {
        }

        public virtual DbSet<UserContext> Users { get; set; }
    }
}