using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().NotNull().WithMessage("Cannot be empty!!");
            RuleFor(x => x.Content).NotEmpty().NotNull().WithMessage("Cannot be empty!!");
            RuleFor(x => x.Image).NotEmpty().NotNull().WithMessage("It Should contain at least 3 letters!!");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("It Should be at least 2 letters!!");
            RuleFor(x => x.Title).MaximumLength(150).WithMessage("It can be at most 150 letters!!");
        }
    }
}
