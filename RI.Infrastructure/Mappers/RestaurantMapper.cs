using RI.Core.Models;

namespace RI.Infrastructure.Mappers
{
    public class RestaurantMapper
    {
        public Restaurant Map(string[] importRecord)
        {
            return new Restaurant()
            {
                Address = importRecord[InspectionImportColumns.Address],
                BusinessName = importRecord[InspectionImportColumns.BusinessName],
                City = importRecord[InspectionImportColumns.City],
                CountyName = importRecord[InspectionImportColumns.CountyName],
                CountyNumber = importRecord[InspectionImportColumns.CountyNumber],
                District = importRecord[InspectionImportColumns.District],
                LicenceNumber = importRecord[InspectionImportColumns.LicenseNumber],
                Zip = importRecord[InspectionImportColumns.Zip]
            };

            // 0-21 & 80-81 = general restaurant data
            // 22-79 = violation details data
        }
    }
}
