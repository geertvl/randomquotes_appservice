using Microsoft.ApplicationInsights;

namespace RandomQuotes.Infrastructure
{
    public class TelemetryClientAccessor
    {
        public static TelemetryClient Instance { get; set; }
    }
}