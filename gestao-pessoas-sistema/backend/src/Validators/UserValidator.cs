public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Nome é obrigatório");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Email inválido");
    }
}