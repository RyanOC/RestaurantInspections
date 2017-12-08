
namespace RI.Core.Contracts.Violation
{
    public interface IViolationRepository
    {
        Models.Violation GetViolationBySourceIndex(int sourceIndex);
    }
}