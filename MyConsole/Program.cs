
using Grpc.Net.Client;
using GrpcGreeter;
using System;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
        }
    }
}
