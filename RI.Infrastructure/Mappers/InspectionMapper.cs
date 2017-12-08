using RI.Core.Models;
using RI.Infrastructure.Extensions;

namespace RI.Infrastructure.Mappers
{
    public class InspectionMapper
    {
        public Inspection Map(string[] importData, int restrauntId, string inspectionVisitId)
        {
            return new Inspection
            {
                RestaurantId = restrauntId,
                InspectionNumber = importData[InspectionImportColumns.CriticalViolationCountLegacy].IfBlankZero(),
                VisitNumber = (importData[InspectionImportColumns.CriticalViolationCountLegacy] == "" ? 0 : int.Parse(importData[InspectionImportColumns.VisitNumber])),
                InspectionType = importData[InspectionImportColumns.InspectionType],
                InspectionDisposition = importData[InspectionImportColumns.InspectionDisposition],
                InspectionDate = importData[InspectionImportColumns.InspectionDate],
                CriticalViolationCountLegacy = (importData[InspectionImportColumns.CriticalViolationCountLegacy] == "" ? 0 : int.Parse(importData[InspectionImportColumns.CriticalViolationCountLegacy])),
                NonCriticalViolationCountLegacy = (importData[InspectionImportColumns.CriticalViolationCountLegacy] == "" ? 0 : int.Parse(importData[InspectionImportColumns.NonCriticalViolationCountLegacy])),
                TotalViolations = (importData[InspectionImportColumns.CriticalViolationCountLegacy] == "" ? 0 : int.Parse(importData[InspectionImportColumns.TotalViolations])),
                HighPriorityViolationCount = (importData[InspectionImportColumns.CriticalViolationCountLegacy] == "" ? 0 : int.Parse(importData[InspectionImportColumns.HighPriorityViolationCount])),
                IntermediatePriorityViolationCount = (importData[InspectionImportColumns.CriticalViolationCountLegacy] == "" ? 0 : int.Parse(importData[InspectionImportColumns.IntermediatePriorityViolationCount])),
                BasicPriorityViolationCount = (importData[InspectionImportColumns.CriticalViolationCountLegacy] == "" ? 0 : int.Parse(importData[InspectionImportColumns.BasicPriorityViolationCount])),
                InspectionVisitId = inspectionVisitId
            };
        }
    }
}
