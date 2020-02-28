using DZRM.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DZRM.Domain.UserAggergate
{
    public class User : Entity<long>, IAggergateBoot
    {
    }
}
