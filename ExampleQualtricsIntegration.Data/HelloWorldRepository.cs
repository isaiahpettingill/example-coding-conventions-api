using System;

namespace ExampleQualtricsIntegration.Data
{

    public class HelloWorldRepository : IHelloWorldRepository
    {
        public string GetHelloMessage()
        {
            return "Hey, World!";
        }
    }

    public interface IHelloWorldRepository
    {
        string GetHelloMessage();
    }

}
