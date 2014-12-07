using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myBuild.Data
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        //just a test row
        public bool Flagged { get; set; }

        public virtual ICollection<Reply> Replies { get; set; }
    }
}