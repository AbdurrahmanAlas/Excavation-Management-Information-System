using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class User
    {
        [Key]
        public int PersonId { get; set; }

        public string  PersonName{ get; set; }
     
        public string PersonSurName { get; set; }
     
        public string PersonAbout { get; set; }

     
        public string PersonImage { get; set; }
  
        public string PersonMail { get; set; }
    
        public string PersonPassword { get; set; }
   
        public string PersonTitle { get; set; }
        public bool PersonStatus { get; set; }
    }
}
