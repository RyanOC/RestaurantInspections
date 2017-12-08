using System.Collections.Generic;
using System.IO;

using CsvHelper;

using RI.Core.Contracts.Inspection;
using RI.Core.Contracts.Restaurant;
using RI.Core.Contracts.Violation;
using RI.Infrastructure.Mappers;

namespace RI.Infrastructure.Services
{
    public class InspectionImportService
    {
        private readonly IRestaurantRepository _repo;
        private readonly IInspectionRepository _insRepo;
        private readonly IViolationRepository _vioRepo;

        public InspectionImportService(
            IRestaurantRepository repo,
            IInspectionRepository insRepo,
            IViolationRepository vioRepo)
        {
            // inject config.csv path (IConfig)
            _repo = repo;
            _insRepo = insRepo;
            _vioRepo = vioRepo;
        }

        public void Import(string csvFilePath)
        {
            int restrauntId = 0;
            int inspectionId = 0;
      
            // List<string> result = new List<string>();

            RestaurantMapper restaurantMapper = new RestaurantMapper();
            InspectionMapper inspectionMapper = new InspectionMapper();

            using (TextReader fileReader = File.OpenText(csvFilePath))
            {
                var csv = new CsvReader(fileReader);
                csv.Configuration.HasHeaderRecord = false;
                while (csv.Read())
                {
                    var data = csv.CurrentRecord;

                    // get restrauntId for adding inspection data...
                    var restraunt = _repo.GetRestaurantByLicenseNumber(data[InspectionImportColumns.LicenseNumber]);
             
                    //TODO: refactor below into a new class? we just want the restrauntId returned

                    if (data[InspectionImportColumns.District] != "" && restraunt == null)
                    {
                        restrauntId = _repo.InsertNewRestaurant(restaurantMapper.Map(data));                       
                    }
                    else if (data[InspectionImportColumns.District] != "" && restraunt != null)
                    {
                        // restraunt already exists. lets get its id and see if there are any new violations.
                        restrauntId = restraunt.Id;
                    }
                    else
                    {
                        // empty data row. go to the next line in the data file
                        continue;
                    }

                    // check if this inspection exists for this restraunt already...
                    var inspectionVisitId = data[InspectionImportColumns.InspectionVisitId];
                    var inspectionRecord = _insRepo.GetInspectionByInspectionVisitId(inspectionVisitId);

                    if (data[InspectionImportColumns.District] != "" && inspectionRecord == null)
                    {
                        inspectionId = _insRepo.InsertNewInspection(inspectionMapper.Map(data, restrauntId, inspectionVisitId));

                        // inspection detail data located in index 22 - 79
                        for (int i = 22; i < 80; i++)
                        {
                            if (data[i] != "0") //bool field for violations
                            {
                                //get violation_lu id for adding to the inspectionvoilation junction table
                                var violation = _vioRepo.GetViolationBySourceIndex(i);
                                var insViolation = _insRepo.GetInspectionViolationByInspectionId(inspectionId);

                                if (insViolation == null)
                                {
                                    //now add the inspection report data..
                                    _insRepo.InsertNewInspectionViolation(new RI.Core.Models.InspectionViolation
                                    {
                                        InspectionId = inspectionId,
                                        ViolationId = violation.Id
                                    });
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}