using Agl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agl.Domain.Repositories
{
    public interface IPersonRepository
    {

        IQueryable<Person> GetPersons();
    }
}
