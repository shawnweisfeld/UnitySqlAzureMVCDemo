using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Repositories
{
    public class TestRepository : ITestRepository
    {
        public DateTime CreatedAt { get; set; }

        public TestRepository()
        {
            CreatedAt = DateTime.Now;
        }

        public string GetTime()
        {
            return CreatedAt.ToShortTimeString();
        }
    }
}