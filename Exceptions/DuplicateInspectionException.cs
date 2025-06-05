using System;

namespace sky_webapi.Exceptions
{    public class DuplicateInspectionException : Exception
    {
        public List<DateTime> ExistingInspectionDates { get; }
        public string SerialNumber { get; }

        public DuplicateInspectionException(IEnumerable<DateTime> existingDates, string serialNumber)
            : base($"There {(existingDates.Count() > 1 ? "are" : "is")} already {(existingDates.Count() > 1 ? $"{existingDates.Count()} incomplete inspections" : "an incomplete inspection")} scheduled for equipment {serialNumber} on:\n{string.Join("\n", existingDates.OrderBy(d => d).Select(d => d.ToString("dd/MM/yyyy")))}")
        {
            ExistingInspectionDates = existingDates.ToList();
            SerialNumber = serialNumber;
        }
    }
}
