using Agenda.Application.DTOs;
using Agenda.Application.Interfaces;
using FluentValidation;
using Agenda.Application.Responses.Results;

namespace Agenda.Application.UseCases.Office
{
  public class CreateOfficeUseCase
  {
    private readonly IOfficeService _service;
    private readonly IValidator<OfficeCreateDto> _validator;

    public CreateOfficeUseCase(
      IOfficeService service,
      IValidator<OfficeCreateDto> validator)
    {
      _validator = validator;
      _service = service;
    }

    public async Task<Result> ExecuteAsync(OfficeCreateDto dto)
    {
      var validation = await _validator.ValidateAsync(dto);
      if (!validation.IsValid)
      {
        return Result.Failure(validation.Errors.Select(e => e.ErrorMessage));
      }

      // var office = new OfficeDto
      // {
      //   Description = dto.Description,
      //   RoomNumber = dto.RoomNumber
      // };

      var result = await _service.CreateAsync(dto);

      return new Result<OfficeDto>(true, result).Success();
    }
  }
}
