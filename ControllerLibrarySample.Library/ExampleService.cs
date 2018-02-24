using System.Collections.Generic;

namespace ControllerLibrarySample.Library
{
    internal class ExampleService : IExampleService
    {
        public IEnumerable<string> Values()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
