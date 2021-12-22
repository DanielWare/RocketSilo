namespace RocketSilo.Api.Systems;

[RequestUrl("/systems/:systemSymbol/ship-listings")]
public class GetAllAvailableShipsInSystemRequest : IApiRequest<GetAllAvailableShipsInSystemResponse>
{
    public string SystemSymbol { get; }
    public GetAllAvailableShipsInSystemRequest(string systemSymbol)
    {
        SystemSymbol = systemSymbol;
    }
}

public class GetAllAvailableShipsInSystemResponse : BaseResponse
{
    public IEnumerable<SystemShip> ShipListings { get; set; } = Enumerable.Empty<SystemShip>();
}