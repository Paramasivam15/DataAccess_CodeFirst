using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock_Model;

namespace ROCK_DAL.Repository
{
    public class CommentRepository : GenericRepository<tb_the_comments>, ICommentRepository
    {       
        public CommentRepository()
        {

        }

        public  IEnumerable<string> GetCommentsByRecValue(string rec)
        {
            
            return _dbset.Where(x=>x.tb_the_recs.rec.Equals(rec)).Select(x => x.comments).ToList();

        }

    }

}