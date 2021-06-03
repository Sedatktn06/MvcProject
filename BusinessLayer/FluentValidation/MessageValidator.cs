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
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage(Messages.NotEmptyReceiverMail);
            RuleFor(x => x.Subject).NotEmpty().WithMessage(Messages.NotEmptySubject);
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage(Messages.NotEmptyMessage);
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage(Messages.SubjectNameMinimumLength);
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage(Messages.SubjectNameMaximumLength2);
            RuleFor(x => x.ReceiverMail).EmailAddress().WithMessage(Messages.InvalidEmail);
        }
    }
}
