using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Escola
{
    public static class PasswordHelper
    {
        // Gera um salt aleatório de 100 bytes (ou qualquer tamanho que preferir)
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
                return Convert.ToBase64String(saltBytes);
        }

        // Gera um hash da senha combinada com o salt usando SHA256
        public static string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string combined = password + salt;
                byte[] bytes = Encoding.UTF8.GetBytes(combined);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
