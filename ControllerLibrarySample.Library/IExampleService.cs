using System.Collections.Generic;

namespace ControllerLibrarySample.Library
{
    public interface IExampleService
    {
        IEnumerable<string> Values();
    }
}