using il.examples.nancyfx.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace il.examples.nancyfx.Common
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> LoadAll()
        {
            return new List<User>
            {
                new User{ EMail = "hallo@mail.de", Password = "123pwd"},
                new User{ EMail = "test@mail.de", Password = "0123pwd11"}
            };
        }
    }
}
