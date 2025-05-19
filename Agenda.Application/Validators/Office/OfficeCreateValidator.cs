using FluentValidation;
using Agenda.Application.DTOs;
using Agenda.Domain.Interfaces;

namespace Agenda.Application.Validators.Office
{
  public class OfficeCreateValidator : AbstractValidator<OfficeCreateDto>
  {
    public OfficeCreateValidator(IOfficeRepository officeRepository)
    {
      RuleFor(x => x.Description)
          .NotEmpty().WithMessage("Descrição é obrigatória.")
          .MinimumLength(3).WithMessage("Descrição deve ter pelo menos 3 caracteres.")
          .MaximumLength(50).WithMessage("Descrição deve ter no máximo 50 caracteres.");

      RuleFor(x => x.RoomNumber)
          .GreaterThan(0).WithMessage("Número da sala deve ser maior que zero.")
          .MustAsync(async (room, cancellation) =>
          {
            return !await officeRepository.ExistsByRoomNumberAsync(room);
          }).WithMessage("Já existe uma sala com esse número.");
    }
  }
}
