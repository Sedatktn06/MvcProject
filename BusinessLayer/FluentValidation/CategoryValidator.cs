using BusinessLayer.Constants;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage(Messages.NotEmptyCategoryName);
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage(Messages.NotEmptyCategoryDescription);
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage(Messages.CategoryNameMinimumLength);
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage(Messages.CategoryNameMaximumLength);
        }
    }
}
