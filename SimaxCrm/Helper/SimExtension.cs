using System;

namespace SimaxCrm.Helper
{
    public static class SimExtension
    {
        public static string ToFormat(this TimeSpan timeSpan, string format = "hh:mm tt")
        {
            DateTime time = DateTime.Today.Add(timeSpan);
            return time.ToString(format);
        }
    }
}
