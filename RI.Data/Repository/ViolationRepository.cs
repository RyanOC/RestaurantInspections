using System.Linq;
using AutoMapper;
using RI.Core.Contracts.Violation;

namespace RI.Data.Repository
{
    public class ViolationRepository: IViolationRepository
    {
        public ViolationRepository()
        {
            //
        }

        public RI.Core.Models.Violation GetViolationBySourceIndex(int sourceIndex)
        {
            using (TestingEntities db = new TestingEntities())
            {
                var d = db.Violation.Where((x) => x.SourceIndex == sourceIndex).FirstOrDefault();
                RI.Core.Models.Violation model = Mapper.Map<RI.Data.Violation, RI.Core.Models.Violation>(d);
                return model;
            }
        }
    }
}
