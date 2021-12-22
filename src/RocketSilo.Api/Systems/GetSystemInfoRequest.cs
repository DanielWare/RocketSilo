namespace RocketSilo.Api.Systems;

[RequestUrl("/systems/:systemSymbol")]
public class GetSystemInfoRequest : IApiRequest<GetSystemInfoResponse>
{
    public string SystemSymbol { get; }

    public GetSystemInfoRequest(string systemSymbol)
    {
        SystemSymbol = systemSymbol;
    }
}

public class GetSystemInfoResponse : BaseResponse
{
    public SystemInfo System { get; set; } = null!;
}