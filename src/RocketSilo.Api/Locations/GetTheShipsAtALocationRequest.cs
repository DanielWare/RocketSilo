namespace RocketSilo.Api.Locations;

[RequestUrl("/locations/:locationSymbol/ships")]
public class GetTheShipsAtALocationRequest : IApiRequest<GetTheShipsAtALocationResponse>
{
    public string LocationSymbol { get; }

    public GetTheShipsAtALocationRequest(string locationSymbol)
    {
        LocationSymbol = locationSymbol;
    }
}

public class GetTheShipsAtALocationResponse : BaseResponse
{
    public IEnumerable<LocationsShip> Ships { get; set; } = Enumerable.Empty<LocationsShip>();
}