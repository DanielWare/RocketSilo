namespace RocketSilo.Api;

public abstract class BaseResponse
{
    public Error? Error { get; set; }

    public bool IsSuccess => Error is null;
}
