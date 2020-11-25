using System.Threading.Tasks;
using Liberis.Analyzer.SharedKernel.Interfaces;
using Liberis.Analyzer.SharedKernel;

namespace Liberis.Analyzer.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
