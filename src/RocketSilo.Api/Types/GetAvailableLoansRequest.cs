namespace RocketSilo.Api.Types;

[RequestUrl("/types/loans")]
public class GetAvailableLoansRequest : IApiRequest<GetAvailableLoansResponse>
{
}

public class GetAvailableLoansResponse : BaseResponse
{
    public IEnumerable<LoanDefinition> Loans { get; set; } = Enumerable.Empty<LoanDefinition>();
}