using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Agl.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IDbContext _dbContext;
        public PersonRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Person> GetPersons()
        {
            return _dbContext.Persons;
        }

    }
}
