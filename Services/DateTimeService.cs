using System;
using System.Globalization;
using aspnetcore_auditable.Interfaces;

namespace aspnetcore_auditable.Services
{
    public class DateTimeService : IDateTime
    {

        public DateTime Now => DateTime.UtcNow.AddHours(7);

        public CultureInfo CultureInfo => new CultureInfo("th-TH");

        public DateTime UnixTime => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    }
}