namespace RocketSilo.Api.FlightPlans;

[RequestUrl("/my/flight-plans", RequestMethod.POST)]
public class SubmitFlightPlanRequest : IApiRequest<SubmitFlightPlanResponse>
{
    public SubmitFlightPlanRequest(string shipId, string destination)
    {
        ShipId = shipId;
        Destination = destination;
    }
    public string ShipId { get; }
    public string Destination { get; }
}

public class SubmitFlightPlanResponse : BaseResponse
{
    public FlightPlan FlightPlan { get; set; } = null!;
}