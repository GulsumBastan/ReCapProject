using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.CompanyName).MinimumLength(2);
            RuleFor(p => p.UserId).NotEmpty();
            

        }
    }
}
