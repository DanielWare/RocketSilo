namespace RocketSilo.Api.Types;

[RequestUrl("/types/ships")]
public class GetAvailableShipsRequest : IApiRequest<GetAvailableShipsResponse>
{
}

public class GetAvailableShipsResponse : BaseResponse
{
    public IEnumerable<ShipDefinition> Ships { get; set; } = Enumerable.Empty<ShipDefinition>();
}