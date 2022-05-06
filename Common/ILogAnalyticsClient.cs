using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalFTPInjestion.Common
{
    public interface ILogAnalyticsClient
    {
        Task SendLogEntry<T>(T entity, string logType);
        Task SendLogEntries<T>(List<T> entities, string logType);
    }
}

/////////////////////////////


