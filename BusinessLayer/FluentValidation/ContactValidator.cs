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
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.UserMail).NotEmpty().WithMessage(Messages.NotEmptyUserMail);
            RuleFor(x => x.Subject).NotEmpty().WithMessage(Messages.NotEmptySubject);
            RuleFor(x => x.UserName).NotEmpty().WithMessage(Messages.NotEmptyUserName);
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage(Messages.SubjectNameMinimumLength);
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage(Messages.UserNameMinimumLength);
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage(Messages.SubjectNameMaximumLength);
        }
    }
}
