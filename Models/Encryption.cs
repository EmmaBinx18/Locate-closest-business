namespace Locate_closest_business.Models
{
    public class Encryption
    {
        private static string GenerateSalt(){
            return BCrypt.Net.BCrypt.GenerateSalt(12);
        }

        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, GenerateSalt());
        }

        private static string VerifyPassword(string password, string correctHash)
        {
            return BCrypt.Verify(password, correctHash);
        }
    }
}