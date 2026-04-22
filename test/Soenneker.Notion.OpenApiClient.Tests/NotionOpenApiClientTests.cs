using Soenneker.Tests.HostedUnit;

namespace Soenneker.Notion.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class NotionOpenApiClientTests : HostedUnitTest
{
    public NotionOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
