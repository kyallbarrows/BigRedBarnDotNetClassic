using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Databasery;
using System.Linq;

namespace DatabaseTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var db = new FeedPostContext()) {
                int newUserid = (new Random()).Next(0, 1000000000);
                var post = new FeedPost() { Id = 123, UserId = newUserid };
                db.Posts.Add(post);
                db.SaveChanges();

                var query = from p in db.Posts
                            where p.UserId == newUserid
                            select p;

                Assert.AreEqual(query.Count(), 1);

                Console.WriteLine("All posts in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.UserId);
                }

                Console.WriteLine("Press any key to exit...");
            }
        }
    }
}
