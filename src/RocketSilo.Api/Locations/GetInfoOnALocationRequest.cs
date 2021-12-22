namespace RocketSilo.Api.Locations;

[RequestUrl("/locations/:locationSymbol")]
public class GetInfoOnALocationRequest : IApiRequest<GetInfoOnALocationResponse>
{
    public string LocationSymbol { get; }

    public GetInfoOnALocationRequest(string locationSymbol)
    {
        LocationSymbol = locationSymbol;
    }
}

public class GetInfoOnALocationResponse : BaseResponse
{
    public Location Location { get; set; } = null!;
}