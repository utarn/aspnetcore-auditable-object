using System;
using System.Globalization;

namespace aspnetcore_auditable.Interfaces
{
    public interface IDateTime
    {
        DateTime Now { get; }
        CultureInfo CultureInfo { get; }
        DateTime UnixTime { get; }
    }
}