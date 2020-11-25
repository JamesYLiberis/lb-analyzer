using System.Threading.Tasks;

namespace Liberis.Analyzer.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}
