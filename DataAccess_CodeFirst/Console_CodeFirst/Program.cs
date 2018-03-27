using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ROCK_DAL;
using ROCK_DAL.Repository;

namespace Console_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string recordvalue;
            Console.WriteLine("Enter Record value");
            recordvalue = Console.ReadLine();
            if (!string.IsNullOrEmpty(recordvalue))
            {
                CommentRepository commentRepository = new CommentRepository();
                List<string> record = commentRepository.GetCommentsByRecValue(recordvalue).ToList();
                if (record.Count > 0)
                {
                    foreach (string comment in record)
                    {
                        Console.WriteLine("Comment value : " + comment);
                    }
                }
                else
                    Console.WriteLine("No records found");

            }
            

            Console.ReadLine();
        }
    }
}
