using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirtYear==1992 && gamer.FirstName=="Numan" && gamer.LastName=="ŞEHRİ"&& gamer.IdentityNumber==12345)

            {
                return true;

            }else
            {
                return false;
            }
        }
    }
}
