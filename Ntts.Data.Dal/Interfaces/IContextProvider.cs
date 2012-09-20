using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Ntts.Data.Dal.Interfaces
{
    public interface IContextProvider
    {
        NttsContext GetNttsContext();
    }
}
