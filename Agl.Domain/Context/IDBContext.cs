using Agl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agl.Domain.Context
{
    public interface IDBContext
    {
        IQueryable<Person> Persons { get; }
    }
}
