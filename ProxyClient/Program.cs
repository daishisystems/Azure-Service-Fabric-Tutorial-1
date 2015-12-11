using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using SimpleActor.Interfaces;

namespace ProxyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var actorId = ActorId.NewId();

            var simpleActor =
                ActorProxy.Create<ISimpleActor>(actorId, "fabric:/MyApplication");

            simpleActor.SetNameAsync("Bob");
            var name = simpleActor.GetNameAsync();

            Console.WriteLine("Hello, " + name.Result);
            Console.ReadLine();
        }
    }
}
