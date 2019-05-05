using Agl.Domain.ViewModels;
using System.Collections.Generic;

namespace Agl.Domain.Services
{
    public interface IPersonService
    {
        IEnumerable<PetsUnderOwnerGender> GetCatsAscByOwnerGender();

    }
}
