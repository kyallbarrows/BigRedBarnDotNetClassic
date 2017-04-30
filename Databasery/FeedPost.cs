using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Databasery
{
    public class FeedPost
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }

    public class FeedPostContext : DbContext
    {
        public FeedPostContext() : base()
        {
        }

        public FeedPostContext(string connection): base(connection)
        {
        }

        public DbSet<FeedPost> Posts { get; set; }
    }
}
