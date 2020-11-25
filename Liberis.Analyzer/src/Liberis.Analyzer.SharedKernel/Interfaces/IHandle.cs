using System.Threading.Tasks;
using Liberis.Analyzer.SharedKernel;

namespace Liberis.Analyzer.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}