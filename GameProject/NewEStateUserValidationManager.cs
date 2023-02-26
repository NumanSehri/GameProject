using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        //yeni sisteme göre doğrulama sisemini entegre etme
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
