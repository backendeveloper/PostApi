using System;
using System.Collections.Specialized;
using System.IO;

namespace Common
{
    public interface IRequestContext
    {
        Guid RequestId { get; }

        string RequestUrl { get; }

        NameValueCollection RequestQueryString { get; }

        NameValueCollection RequestForm { get; }

        Stream RequestPayload { get; }
    }
}