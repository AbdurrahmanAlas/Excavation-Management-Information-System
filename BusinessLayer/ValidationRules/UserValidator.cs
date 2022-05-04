using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {

            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Kullanıcı Adı Boş geçilemez");
            RuleFor(x => x.PersonMail).NotEmpty().WithMessage("Mail Adresi Boş geçilemez");
            RuleFor(x => x.PersonPassword).NotEmpty().WithMessage(" Şifre Boş geçilemez");
            RuleFor(x => x.PersonName).MinimumLength(2).WithMessage("En az iki karakter giriş yap");
            
            


        }

    }
}
