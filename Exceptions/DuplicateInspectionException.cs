using System;

namespace sky_webapi.Exceptions
{
    public class DuplicateInspectionException : Exception
    {
        public DateTime ExistingInspectionDate { get; }
        public string SerialNumber { get; }

        public DuplicateInspectionException(DateTime existingDate, string serialNumber)
            : base($"There is already an incomplete inspection scheduled for equipment {serialNumber} on {existingDate:d}")
        {
            ExistingInspectionDate = existingDate;
            SerialNumber = serialNumber;
        }
    }
}
