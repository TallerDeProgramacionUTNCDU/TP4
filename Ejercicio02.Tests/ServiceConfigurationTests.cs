using Ejercicio_02;
using System.Globalization;

namespace Ejercicio_02_Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ServiceConfigurationTests
    {
        [TestCase()]
        public void Validate_Failed()
        {
            var url = "qqq.thisIsNotaValidURL_google.html";
            var id = "0RiotGMf45lYSmoD";
            var secret = "zsOJpfOR5f26DPLU";
            var timeout = 1000;
            var serviceConfig = new ServiceConfiguration(url,id,secret);
            serviceConfig.Timeout=timeout;
            Assert.Throws<ExceptionUnvalidConfig>(()=>serviceConfig.Validate());
        }
    }
}