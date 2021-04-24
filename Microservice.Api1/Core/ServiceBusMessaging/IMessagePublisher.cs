using System.Threading.Tasks;

namespace Microservice.Api1.Core.ServiceBusMessaging
{
    public interface IMessagePublisher
    {
        Task PublishAsync<T>(T request);
    }
}
