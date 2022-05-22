using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Cannot be empty!!");
            RuleFor(x => x.Email).EmailAddress().NotEmpty().NotNull().WithMessage("Should be a correct EmailAddress!!");
            RuleFor(x => x.Password).MinimumLength(3).NotEmpty().NotNull().WithMessage("It Should contain at least 3 letters!!");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("It Should be at least 2 letters!!");
            RuleFor(x => x.Name).MaximumLength(2).WithMessage("It can be at most 50 letters!!");
        }
    }
}
