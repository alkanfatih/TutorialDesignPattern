using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ProxyDesignPattern.LAB_2
{
    public class ProxyBanka : IBanka
    {
        Banka _banka;
        bool _login;
        string _userName, _password;

        public ProxyBanka(string userName, string password)
        {
            _userName = userName;
            _password = password;
        }

        bool GirisYap()
        {
            if (_userName == "yonetici" && _password.Equals("1234"))
            {
                _login = true;
                _banka = new Banka();
                Console.WriteLine("Giriş Başarılı!");
                return true;
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!");
                _login = false;
                return false;
            }

            //return false;
        }

        public bool OdemeYap(double tutar)
        {
            GirisYap(); // Giriş yapılabilirse true dönecek.

            if (!_login) // _login == false
            {
                Console.WriteLine("Hesaba giriş yapılamadığı için ödeme gerçekleştirilemeyecektir!");
                return false;
            }

            _banka.Pay(tutar);
            return true;
        }
    }
}
