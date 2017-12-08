
namespace RI.Core.Contracts.Inspection
{
    public interface IInspectionRepository
    {
        Models.Inspection GetInspectionByInspectionVisitId(string inspectionVisitId);
        Models.InspectionViolation GetInspectionViolationByInspectionId(int inspectionId);
        int InsertNewInspection(Models.Inspection inspection);
        int InsertNewInspectionViolation(Models.InspectionViolation inspectionViolation);
    }
}