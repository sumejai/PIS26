using System;

namespace PISVezba
{
    public static class Sesija
    {
        public static int KorisnikId { get; set; }
        public static string KorisnickoIme { get; set; }
        public static string Rola { get; set; }

        public static bool JeAdmin
        {
            get { return string.Equals(Rola, "admin", StringComparison.OrdinalIgnoreCase); }
        }
    }
}