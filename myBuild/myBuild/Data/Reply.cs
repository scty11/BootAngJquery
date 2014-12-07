using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myBuild.Data
{
    public class Reply
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }

        public virtual int TopicId { get; set; }
    }
}
