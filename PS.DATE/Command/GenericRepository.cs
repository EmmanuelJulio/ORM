using PS.DOMAIN.Comands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.DATE.Command
{
    public class GenericRepository : IGenericsRepository
    {
        private readonly ApplicationDbContext context;
        public GenericRepository (ApplicationDbContext dbcontext)
        {
            context = dbcontext;
        }
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
            //baeofjhsarhg;orasng
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetALL<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
