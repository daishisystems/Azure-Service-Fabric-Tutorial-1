using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace SimpleActor.Interfaces
{
    /// <summary>
    ///     This interface represents the actions a client app can perform on an
    ///     actor. It MUST derive from IActor and all methods MUST return a Task.
    /// </summary>
    public interface ISimpleActor : IActor
    {
        Task<int> GetCountAsync();

        Task SetCountAsync(int count);

        Task<string> GetNameAsync();

        Task SetNameAsync(string name);
    }
}