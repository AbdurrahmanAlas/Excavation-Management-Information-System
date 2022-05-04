using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class StructureValidator: AbstractValidator<Structure>
    {


        public StructureValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Firma Adını boş geçemezsiniz");
            RuleFor(x => x.Island).NotEmpty().WithMessage("Ada Numarasınıı boş geçemezsiniz");
            RuleFor(x => x.Parcel).NotEmpty().WithMessage("Parsel Numarasınıı boş geçemezsiniz");

        }
    }
}
