using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.BrandId).NotEmpty();
            
        }
    }
}
