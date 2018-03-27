using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock_Model;
namespace ROCK_DAL.Repository
{
    public interface ICommentRepository : IGenericRepository<tb_the_comments>
    {
        IEnumerable<string> GetCommentsByRecValue(string rec);
    }
}
