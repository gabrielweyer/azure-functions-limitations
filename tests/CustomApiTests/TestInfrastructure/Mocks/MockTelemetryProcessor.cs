using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;

namespace CustomApiTests.TestInfrastructure.Mocks
{
    public class MockTelemetryProcessor : ITelemetryProcessor
    {
        public bool WasProcessorCalled { get; private set; }

        public void Process(ITelemetry item)
        {
            WasProcessorCalled = true;
        }
    }
}