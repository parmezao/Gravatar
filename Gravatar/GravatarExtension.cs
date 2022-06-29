using System.Security.Cryptography;
using System.Text;

namespace Gravatar 
{
    public static class GravatarExtension
    {
        public static string ToGravatar(this string email, int size = 60)
        {
            if (string.IsNullOrEmpty(email)) return string.Empty;

            using var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(email);
            var hashBytes = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (var i in hashBytes)
            {
                sb.Append(i.ToString("X2"));
            }

            return $"https://www.gravatar.com/avatar/{sb.ToString().ToLower()}?s={size}";
        }
    }
}

