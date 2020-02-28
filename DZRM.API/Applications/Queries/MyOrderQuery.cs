using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZRM.API.Applications.Queries
{
    public class MyOrderQuery : IRequest<List<string>>
    {
        public MyOrderQuery(string userName) => UserName = userName;

        public string UserName { get; private set; }
    }
}
