using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rock_Model
{
    public class tb_the_recs : Entity<long>
    {
        public tb_the_recs()
        {
            this.tb_the_comments = new HashSet<tb_the_comments>();
        }        
        public string rec { get; set; }

        public virtual ICollection<tb_the_comments> tb_the_comments { get; set; }
    }
}
