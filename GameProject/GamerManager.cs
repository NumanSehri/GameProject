using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //MicroService
    public class GamerManager : IGamerService
    {

        //sınıf içinde başka bir sınıf kullancaksan new leme,
        //yerine adını yaz altire ile constructor oluştur

        IUserValidationService _userValidationService;

        //gamermanager içinde doğrulama sistemi kullanacağım, yazılan 
        //interface kullanıyoruz . interface yazılan çalışacaktır
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }





        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Oyunncu Kayıt Edildi");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız, Kayıt Başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyunncu Kayıt Güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyunncu Kayıt Silindi");
        }
    }
}
