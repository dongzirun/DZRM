using System;
using System.Collections.Generic;
using System.Text;
using DZRM.Domain.UserAggergate;
using DZRM.Infrastucture.Core;

namespace DZRM.Infrastructure.Repositories
{
    class UserRepository : Repository<User, long, DomainContext>
    {
        public UserRepository(DomainContext context) : base(context)
        {

        }
    }
}
