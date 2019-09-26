using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Common.API.Interface
{
    public interface IUrlApiFactory
    {        
        string GetUrl(string serviceType);
    }
}
