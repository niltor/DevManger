using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class BaseService
    {
        public readonly DevContext ctx;
        public BaseService(DevContext context)
        {
            ctx = context;
        }
    }
}
