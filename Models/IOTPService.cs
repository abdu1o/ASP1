namespace ASP1.Models
{
    public interface IOTPService
    {
        string GenerateOTP();
    }

    public class OTP6DigitService : IOTPService
    {
        public string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }

    public class OTP4DigitService : IOTPService
    {
        public string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }
    }


}
