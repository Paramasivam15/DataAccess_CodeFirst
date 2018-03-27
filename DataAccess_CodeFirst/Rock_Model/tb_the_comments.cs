using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rock_Model
{
    public class tb_the_comments : Entity<long>
    {
       // public long ID { get; set; }
        public long rec_the_Id { get; set; }
        public string comments { get; set; }

        public virtual tb_the_recs tb_the_recs { get; set; }
    }
}
