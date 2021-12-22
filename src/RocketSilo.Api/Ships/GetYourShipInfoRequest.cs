namespace RocketSilo.Api.Ships;

[RequestUrl("/my/ships/:shipId")]
public class GetYourShipInfoRequest : IApiRequest<GetYourShipInfoResponse>
{
    public string ShipId { get; }

    public GetYourShipInfoRequest(string shipId)
    {
        ShipId = shipId;
    }
}

public class GetYourShipInfoResponse : BaseResponse
{
    public Ship Ship { get; set; } = null!;
}