using FluentValidation;
using gms.common.Models.Gym;

namespace gms.common.Validation.Gym;

public class CreateGymDtoValidator : AbstractValidator<CreateGymDTO>
{
    public CreateGymDtoValidator()
    {
        RuleFor(gym => gym.Name)
            .NotEmpty().WithMessage("Name is required.")
            .Length(2, 100).WithMessage("Name must be between 2 and 100 characters.");
    }
}
