namespace RocketSilo.Api.Structures;

[RequestUrl("/my/structures")]
public class GetAllMyStructuresRequest: IApiRequest<GetAllMyStructuresResponse>
{
}

public class GetAllMyStructuresResponse : BaseResponse
{
    public IEnumerable<Structure> Structures { get; set; } = Enumerable.Empty<Structure>();
}