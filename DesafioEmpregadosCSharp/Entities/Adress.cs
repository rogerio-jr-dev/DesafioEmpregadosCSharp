using System;
using System.Collections.Generic;


namespace DesafioEmpregadosCSharp.Entities
{
    internal class Adress
    {
        public string Email { get; set; }
        public string Phone { get; set; }

        public Adress() { }
        public Adress(string email, string phone)
        {
            Email = email;
            Phone = phone;
        }


        public override string ToString()
        {
            return Email;
        }
    }
}
