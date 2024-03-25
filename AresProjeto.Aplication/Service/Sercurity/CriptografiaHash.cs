using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AresProjeto.Aplication.Service.Sercurity
{
    public static class CriptografiaHash
    {
        public static string GerarHash(this string Valor)
        {
            var hash = SHA256.Create();
            var encoding = new ASCIIEncoding();
            var array = encoding.GetBytes(Valor);

            array = hash.ComputeHash(array);

            var strHexa = new StringBuilder();

            foreach (var item in array)
            {
                strHexa.Append(item.ToString("x2"));

            }

            return strHexa.ToString();
        }
    }
}
