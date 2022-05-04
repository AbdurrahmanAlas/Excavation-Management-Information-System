using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class CompanyValidator:AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Firma Adını boş geçemezsiniz");
            RuleFor(x => x.TexNumber).NotEmpty().WithMessage("Vergi Numarasınıı boş geçemezsiniz");
           
        }
    }
}
