using il.examples.nancyfx.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace il.examples.nancyfx.Common
{
    public interface IUserRepository
    {
        IEnumerable<User> LoadAll();
    }
}
