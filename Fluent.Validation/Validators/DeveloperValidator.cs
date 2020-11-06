using System;
using System.Linq;
using Fluent.Validation.Models;
using FluentValidation;

namespace Fluent.Validation.Validators
{
    public class DeveloperValidator: AbstractValidator<Developer>
    {
        public DeveloperValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} should be not empty")
                .Length(2, 20)
                .Must(IsValidName).WithMessage("{PropertyName} should be all letter");
        }

        private bool IsValidName(string name)
        {
            return name.All(char.IsLetter);
        }
    }
}