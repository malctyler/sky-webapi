using Microsoft.EntityFrameworkCore;
using sky_webapi.Data.Entities;

namespace sky_webapi.Data
{
    public static class DatabaseSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Plant Categories
            modelBuilder.Entity<PlantCategoryEntity>().HasData(
                new PlantCategoryEntity { CategoryID = 1, CategoryDescription = "Heavy Plant" },
                new PlantCategoryEntity { CategoryID = 2, CategoryDescription = "Small Plant" },
                new PlantCategoryEntity { CategoryID = 3, CategoryDescription = "Access Equipment" },
                new PlantCategoryEntity { CategoryID = 4, CategoryDescription = "Power Tools" },
                new PlantCategoryEntity { CategoryID = 5, CategoryDescription = "Safety Equipment" }
            );

            // Seed Status
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusID = 1, StatusDescription = "Available" },
                new Status { StatusID = 2, StatusDescription = "In Use" },
                new Status { StatusID = 3, StatusDescription = "Under Maintenance" },
                new Status { StatusID = 4, StatusDescription = "Out of Service" },
                new Status { StatusID = 5, StatusDescription = "Reserved" }
            );

            // Seed Inspectors
            modelBuilder.Entity<InspectorEntity>().HasData(
                new InspectorEntity { InspectorID = 1, InspectorsName = "Allen Lee" },
                new InspectorEntity { InspectorID = 2, InspectorsName = "Aidan Lee" }
            );

            // Seed All Plant
            modelBuilder.Entity<AllPlantEntity>().HasData(
                new AllPlantEntity { PlantNameID = 1, NormalPrice = "150.00", PlantCategory = 1, PlantDescription = "Excavator 2T" },
                new AllPlantEntity { PlantNameID = 2, NormalPrice = "95.00", PlantCategory = 3, PlantDescription = "Scissor Lift" },
                new AllPlantEntity { PlantNameID = 3, NormalPrice = "45.00", PlantCategory = 2, PlantDescription = "Concrete Mixer" },
                new AllPlantEntity { PlantNameID = 4, NormalPrice = "25.00", PlantCategory = 4, PlantDescription = "Power Drill" },
                new AllPlantEntity { PlantNameID = 5, NormalPrice = "15.00", PlantCategory = 5, PlantDescription = "Safety Harness" }
            );

            // Seed Summaries
            modelBuilder.Entity<Summary>().HasData(
                new Summary { Id = 1, Description = "Freezing" },
                new Summary { Id = 2, Description = "Bracing" },
                new Summary { Id = 3, Description = "Chilly" },
                new Summary { Id = 4, Description = "Cool" },
                new Summary { Id = 5, Description = "Mild" },
                new Summary { Id = 6, Description = "Warm" },
                new Summary { Id = 7, Description = "Balmy" },
                new Summary { Id = 8, Description = "Hot" },
                new Summary { Id = 9, Description = "Sweltering" },
                new Summary { Id = 10, Description = "Scorching" }
            );

            // Seed a minimal set of customers (just 10 for testing)
            modelBuilder.Entity<CustomerEntity>().HasData(
                new CustomerEntity { CustID = 1, CompanyName = "Company A", ContactFirstNames = "John", ContactSurname = "Doe", ContactTitle = "Mr.", Email = "john.doe@companya.com", Telephone = "123-456-7890", Fax = "123-456-7891", Line1 = "123 Main St", Line2 = "", Line3 = "", Line4 = "", Postcode = "SO14 1KX" },
                new CustomerEntity { CustID = 2, CompanyName = "Company B", ContactFirstNames = "Jane", ContactSurname = "Smith", ContactTitle = "Ms.", Email = "jane.smith@companyb.com", Telephone = "123-456-7892", Fax = "123-456-7893", Line1 = "456 Oak Ave", Line2 = "", Line3 = "", Line4 = "", Postcode = "PL4 6LU" },
                new CustomerEntity { CustID = 3, CompanyName = "Company C", ContactFirstNames = "Mike", ContactSurname = "Johnson", ContactTitle = "Mr.", Email = "mike.johnson@companyc.com", Telephone = "123-456-7894", Fax = "123-456-7895", Line1 = "789 Pine Rd", Line2 = "", Line3 = "", Line4 = "", Postcode = "PO1 8VI" },
                new CustomerEntity { CustID = 4, CompanyName = "Company D", ContactFirstNames = "Sarah", ContactSurname = "Williams", ContactTitle = "Mrs.", Email = "sarah.williams@companyd.com", Telephone = "123-456-7896", Fax = "123-456-7897", Line1 = "321 Elm St", Line2 = "", Line3 = "", Line4 = "", Postcode = "CT3 8AB" },
                new CustomerEntity { CustID = 5, CompanyName = "Company E", ContactFirstNames = "David", ContactSurname = "Brown", ContactTitle = "Mr.", Email = "david.brown@companye.com", Telephone = "123-456-7898", Fax = "123-456-7899", Line1 = "654 Maple Dr", Line2 = "", Line3 = "", Line4 = "", Postcode = "TR2 7VM" },
                new CustomerEntity { CustID = 6, CompanyName = "Company F", ContactFirstNames = "Lisa", ContactSurname = "Davis", ContactTitle = "Ms.", Email = "lisa.davis@companyf.com", Telephone = "123-456-7800", Fax = "123-456-7801", Line1 = "987 Cedar Ln", Line2 = "", Line3 = "", Line4 = "", Postcode = "SW1 5RZ" },
                new CustomerEntity { CustID = 7, CompanyName = "Company G", ContactFirstNames = "Robert", ContactSurname = "Miller", ContactTitle = "Mr.", Email = "robert.miller@companyg.com", Telephone = "123-456-7802", Fax = "123-456-7803", Line1 = "147 Birch Way", Line2 = "", Line3 = "", Line4 = "", Postcode = "SW9 1JP" },
                new CustomerEntity { CustID = 8, CompanyName = "Company H", ContactFirstNames = "Jennifer", ContactSurname = "Wilson", ContactTitle = "Mrs.", Email = "jennifer.wilson@companyh.com", Telephone = "123-456-7804", Fax = "123-456-7805", Line1 = "258 Spruce St", Line2 = "", Line3 = "", Line4 = "", Postcode = "SW2 9FA" },
                new CustomerEntity { CustID = 9, CompanyName = "Company I", ContactFirstNames = "Michael", ContactSurname = "Moore", ContactTitle = "Mr.", Email = "michael.moore@companyi.com", Telephone = "123-456-7806", Fax = "123-456-7807", Line1 = "369 Willow Ave", Line2 = "", Line3 = "", Line4 = "", Postcode = "PO3 8UT" },
                new CustomerEntity { CustID = 10, CompanyName = "Company J", ContactFirstNames = "Amanda", ContactSurname = "Taylor", ContactTitle = "Ms.", Email = "amanda.taylor@companyj.com", Telephone = "123-456-7808", Fax = "123-456-7809", Line1 = "741 Poplar Rd", Line2 = "", Line3 = "", Line4 = "", Postcode = "PL4 9DV" }
            );

            // Seed some plant holdings
            modelBuilder.Entity<PlantHolding>().HasData(
                new PlantHolding { HoldingID = 1, CustID = 1, InspectionFee = 105m, InspectionFrequency = 12, PlantNameID = 2, SWL = "500kg", SerialNumber = "B2D4F6H8J0", StatusID = 2 },
                new PlantHolding { HoldingID = 2, CustID = 2, InspectionFee = 170m, InspectionFrequency = 12, PlantNameID = 3, SWL = "300kg", SerialNumber = "C3E5G7I9K1", StatusID = 3 },
                new PlantHolding { HoldingID = 3, CustID = 3, InspectionFee = 110m, InspectionFrequency = 12, PlantNameID = 4, SWL = "N/A", SerialNumber = "D4F6H8J0L2", StatusID = 4 },
                new PlantHolding { HoldingID = 4, CustID = 4, InspectionFee = 175m, InspectionFrequency = 12, PlantNameID = 5, SWL = "150kg", SerialNumber = "E5G7I9K1M3", StatusID = 5 },
                new PlantHolding { HoldingID = 5, CustID = 5, InspectionFee = 115m, InspectionFrequency = 12, PlantNameID = 1, SWL = "2000kg", SerialNumber = "F6H8J0L2N4", StatusID = 1 },
                new PlantHolding { HoldingID = 6, CustID = 6, InspectionFee = 180m, InspectionFrequency = 12, PlantNameID = 2, SWL = "500kg", SerialNumber = "G7I9K1M3O5", StatusID = 2 },
                new PlantHolding { HoldingID = 7, CustID = 7, InspectionFee = 120m, InspectionFrequency = 12, PlantNameID = 3, SWL = "300kg", SerialNumber = "H8J0L2N4P6", StatusID = 3 },
                new PlantHolding { HoldingID = 8, CustID = 8, InspectionFee = 185m, InspectionFrequency = 12, PlantNameID = 4, SWL = "N/A", SerialNumber = "I9K1M3O5Q7", StatusID = 4 },
                new PlantHolding { HoldingID = 9, CustID = 9, InspectionFee = 125m, InspectionFrequency = 12, PlantNameID = 5, SWL = "150kg", SerialNumber = "J0L2N4P6R8", StatusID = 5 },
                new PlantHolding { HoldingID = 10, CustID = 10, InspectionFee = 190m, InspectionFrequency = 12, PlantNameID = 1, SWL = "2000kg", SerialNumber = "K1M3O5Q7S9", StatusID = 1 }
            );

            // Seed some inspections
            modelBuilder.Entity<Inspection>().HasData(
                new Inspection { UniqueRef = 1, Defects = "None", HoldingID = 1, InspectionDate = new DateTime(2025, 5, 1), InspectorID = 2, LatestDate = new DateTime(2025, 5, 1), Location = "Site 1", MiscNotes = "Annual inspection for plant holding 1", PreviousCheck = "N/A", RecentCheck = "Completed", Rectified = "N/A", SafeWorking = "Yes", TestDetails = "Standard inspection completed" },
                new Inspection { UniqueRef = 2, Defects = "None", HoldingID = 2, InspectionDate = new DateTime(2025, 4, 1), InspectorID = 1, LatestDate = new DateTime(2025, 4, 1), Location = "Site 2", MiscNotes = "Annual inspection for plant holding 2", PreviousCheck = "N/A", RecentCheck = "Completed", Rectified = "N/A", SafeWorking = "Yes", TestDetails = "Standard inspection completed" },
                new Inspection { UniqueRef = 3, Defects = "None", HoldingID = 3, InspectionDate = new DateTime(2025, 3, 1), InspectorID = 2, LatestDate = new DateTime(2025, 3, 1), Location = "Site 3", MiscNotes = "Annual inspection for plant holding 3", PreviousCheck = "N/A", RecentCheck = "Completed", Rectified = "N/A", SafeWorking = "Yes", TestDetails = "Standard inspection completed" },
                new Inspection { UniqueRef = 4, Defects = "None", HoldingID = 4, InspectionDate = new DateTime(2025, 2, 1), InspectorID = 1, LatestDate = new DateTime(2025, 2, 1), Location = "Site 4", MiscNotes = "Annual inspection for plant holding 4", PreviousCheck = "N/A", RecentCheck = "Completed", Rectified = "N/A", SafeWorking = "Yes", TestDetails = "Standard inspection completed" },
                new Inspection { UniqueRef = 5, Defects = "None", HoldingID = 5, InspectionDate = new DateTime(2025, 1, 1), InspectorID = 2, LatestDate = new DateTime(2025, 1, 1), Location = "Site 5", MiscNotes = "Annual inspection for plant holding 5", PreviousCheck = "N/A", RecentCheck = "Completed", Rectified = "N/A", SafeWorking = "Yes", TestDetails = "Standard inspection completed" }
            );
        }
    }
}
