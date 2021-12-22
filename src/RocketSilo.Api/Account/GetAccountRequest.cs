using RocketSilo.Api.Users;

namespace RocketSilo.Api.Account;

[RequestUrl("/my/account")]
public class GetAccountRequest : IApiRequest<GetAccountResponse> { }

public class GetAccountResponse : BaseResponse
{
    public User User { get; set; } = null!;
}

