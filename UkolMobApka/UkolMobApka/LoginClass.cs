using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UkolMobApka
{
    public class LoginClass
    {
        public string Osloveni { get; set; }
        public string Name { get; set; }
        private string myPass;
        public string Pass
        {
            get { return myPass; }
            set {
                if (value.ToCharArray().Length < 8)
                    myPass = "Chyba! Musí obsahovat alespoň 8 znaků.";
                else if (value.All(char.IsDigit))
                    myPass = "Chyba! Musí obsahovat alespoň 1 písmeno.";
                else if (!value.Any(char.IsDigit))
                    myPass = "Chyba! Musí obsahovat alespoň 1 číslo.";
                else if (value.ToLower() == value)
                    myPass = "Chyba! Musí obsahovat alespoň 1 velké písmeno.";
                else
                    myPass = value; 
            }
        }

        public LoginClass() {}
        public LoginClass(string osloveni, string name, string pass)
        {
            Osloveni = osloveni;
            Name = name;
            Pass = pass;
        }
    }
}
