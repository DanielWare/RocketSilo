namespace RocketSilo.Api.Systems;

[RequestUrl("/systems/:systemSymbol/ships")]
public class GetSystemDockedShipsRequest : IApiRequest<GetSystemDockedShipsResponse>
{
    public string SystemSymbol { get; }
    public GetSystemDockedShipsRequest(string systemSymbol)
    {
        SystemSymbol = systemSymbol;
    }
}

public class GetSystemDockedShipsResponse : BaseResponse
{
    public IEnumerable<SystemDockedShip> Ships { get; set; } = Enumerable.Empty<SystemDockedShip>();
}