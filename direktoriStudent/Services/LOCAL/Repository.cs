using direktoriStudent.Data;
using direktoriStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace direktoriStudent.Services.LOCAL
{
    public class Repository : IRepository
    {

        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Student> GetSemuaStudent()
        {
            List<Student> results = new List<Student>();

            try
            {
                results = _context.Student.ToList();
            }
            catch (Exception)
            {

                //throw;
            }

            return results;
        }
    }
}
