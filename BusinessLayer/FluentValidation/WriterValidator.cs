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
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage(Messages.NotEmptyWriterName);
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage(Messages.NotEmptyWriterSurname);
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage(Messages.NotEmptyAbout);
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage(Messages.NotEmptyTitle);
            RuleFor(x => x.WriterAbout).Must(ContainA).WithMessage(Messages.MustContainA);
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage(Messages.WriterNameMinimumLength);
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage(Messages.WriterSurnameMaximumLength);
        }

        private bool ContainA(string arg)
        {
            return arg.Contains("a");
        }
    }
}
