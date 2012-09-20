using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Ntts.Data.Dal.Interfaces;

namespace Ntts.Data.Dal
{
    public class ContextProvider : IContextProvider
    {
        public NttsContext GetNttsContext()
        {
            return new NttsContext();
        }
    }
}
