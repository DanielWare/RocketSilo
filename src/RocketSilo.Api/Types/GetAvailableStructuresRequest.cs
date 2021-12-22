namespace RocketSilo.Api.Types;

[RequestUrl("/types/structures")]
public class GetAvailableStructuresRequest : IApiRequest<GetAvailableStructuresResponse>
{
}

public class GetAvailableStructuresResponse : BaseResponse
{
    public IEnumerable<StructureDefinition> Structures { get; set; } = Enumerable.Empty<StructureDefinition>();
}