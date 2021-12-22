using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using RocketSilo.Api.Game;

namespace RocketSilo.Api.Tests;

public class StatusTest
{
    private IClient client = null!;

    [SetUp]
    public void SetUp()
    {
        HttpClient httpClient = new();
        IOptions<RocketSiloConfig> config = new OptionsWrapper<RocketSiloConfig>(new RocketSiloConfig { BaseUrl = RocketSiloConfig.DefaultBaseUrl });
        IClientFactory clientFactory = new ClientFactory(httpClient, config);
        client = clientFactory.GetClient(string.Empty);
    }

    [Test]
    public async Task Test_Status()
    {
        GetGameStatusResponse response = await client.GetGameStatusAsync(new GetGameStatusRequest());
        response.IsSuccess.Should().BeTrue();
        response.Error.Should().BeNull();
        response.Status.Should().NotBeEmpty();
    }
}
