namespace RI.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static int IfBlankZero(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return 0;
            }

            return int.Parse(data);
        }
    }
}