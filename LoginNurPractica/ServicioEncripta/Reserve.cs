using System;

namespace Encriptacion
{
    public class Reverse
    {
        public string Reverse1(string valor)
        {
            char[] charArrray = valor.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArrray.Length - 1; i >= 0; i--)
            {
                reverse += charArrray[i];
            }
            return reverse;
        }
    }
}