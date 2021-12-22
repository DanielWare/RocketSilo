namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships/:shipId/", RequestMethod.DELETE)]
public class ScrapShipRequest : IApiRequest<ScrapShipResponse>
{
    public string ShipId { get; }

    public ScrapShipRequest(string shipId)
    {
        ShipId = shipId;
    }
}

public class ScrapShipResponse : BaseResponse
{
    public string Success { get; set; } = null!;
}