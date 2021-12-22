namespace RocketSilo.Api.Loans;

[RequestUrl("/my/loans")]
public class GetYourLoansRequest : IApiRequest<GetYourLoansResponse>
{
}

public class GetYourLoansResponse : BaseResponse
{
    public IEnumerable<Loan> Loans { get; set; } = Enumerable.Empty<Loan>();
}