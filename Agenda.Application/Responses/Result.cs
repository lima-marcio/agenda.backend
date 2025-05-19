namespace Agenda.Application.Responses.Results
{
  public class Result
  {
    public bool IsSuccess { get; private set; }
    public bool IsFailure => !IsSuccess;
    public IEnumerable<string>? Errors { get; private set; }

    protected Result(bool isSuccess, IEnumerable<string>? errors = null)
    {
      IsSuccess = isSuccess;
      Errors = errors;
    }

    public static Result Success()
    {
      return new Result(true);
    }

    public static Result Failure(IEnumerable<string> errors)
    {
      return new Result(false, errors);
    }
  }

  public class Result<T> : Result
  {
    public T? Value { get; private set; }

    protected Result(bool isSuccess, T? value, IEnumerable<string>? errors = null)
        : base(isSuccess, errors)
    {
      Value = value;
    }

    public static Result<T> Success(T value)
    {
      return new Result<T>(true, value);
    }

    public static new Result<T> Failure(IEnumerable<string> errors)
    {
      return new Result<T>(false, default, errors);
    }
  }
}
