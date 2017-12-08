using System.Linq;
using AutoMapper;
using RI.Core.Contracts.Inspection;

namespace RI.Data.Repository

{
    public class InspectionRepository: IInspectionRepository
    {
        public InspectionRepository()
        {
            //
        }

        public RI.Core.Models.Inspection GetInspectionByInspectionVisitId(string inspectionVisitId)
        {
            using (TestingEntities db = new TestingEntities())
            {
                var d = db.Inspection.Where((x) => x.InspectionVisitId == inspectionVisitId).FirstOrDefault();
                RI.Core.Models.Inspection inspectionModel = Mapper.Map<Inspection, RI.Core.Models.Inspection>(d);
                return inspectionModel;
            }
        }

        public RI.Core.Models.InspectionViolation GetInspectionViolationByInspectionId(int inspectionId)
        {
            using (TestingEntities db = new TestingEntities())
            {
                var d = db.InspectionViolation.Where((x) => x.InspectionId == inspectionId).FirstOrDefault();
                RI.Core.Models.InspectionViolation model = Mapper.Map<InspectionViolation, RI.Core.Models.InspectionViolation>(d);
                return model;
            }
        }

        public int InsertNewInspection(RI.Core.Models.Inspection inspection)
        {
            using (TestingEntities db = new TestingEntities())
            {
                Inspection i = Mapper.Map<RI.Core.Models.Inspection, Inspection>(inspection);
                db.Inspection.Add(i);
                db.SaveChanges();
                return i.Id;
            }
        }

        public int InsertNewInspectionViolation(RI.Core.Models.InspectionViolation inspectionViolation)
        {
            using (TestingEntities db = new TestingEntities())
            {
                InspectionViolation i = Mapper.Map<RI.Core.Models.InspectionViolation, InspectionViolation>(inspectionViolation);
                db.InspectionViolation.Add(i);
                db.SaveChanges();
                return i.Id;
            }
        }
    }
}
