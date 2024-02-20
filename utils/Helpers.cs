namespace c_.utils
{
    public class Helpers
    {
        public string GetTelecomOperator(string phoneNumber)
        {
            if (phoneNumber.StartsWith("078") || phoneNumber.StartsWith("079"))
            {
                return "MTN";
            }
            else if (phoneNumber.StartsWith("073") || phoneNumber.StartsWith("072"))
            {
                return "Airtel";
            }
            else
            {
                return "Unknown Operator";
            }
        }

    }
}
