using System.Threading.Tasks;
using Liberis.Analyzer.SharedKernel;

namespace Liberis.Analyzer.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}