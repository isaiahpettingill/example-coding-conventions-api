using ExampleQualtricsIntegration.Data;
using System;

namespace ExampleQualtricsIntegration.Services
{

    public class HelloWorldService : IHelloWorldService
    {
        private readonly IHelloWorldRepository _helloWorldRepository;
        public HelloWorldService(IHelloWorldRepository helloWorldRepository)
        {
            _helloWorldRepository = helloWorldRepository;
        }
        public string SayHello()
        {
            return _helloWorldRepository.GetHelloMessage() + "I got this from the repository using the services layer!";
        }
    }
    public interface IHelloWorldService
    {
        string SayHello();
    }

}
