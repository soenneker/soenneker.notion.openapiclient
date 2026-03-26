using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Notion.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class NotionOpenApiClientTests : FixturedUnitTest
{
    public NotionOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
