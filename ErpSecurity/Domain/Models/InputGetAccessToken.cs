namespace ErpSecurity.Domain.Models
{
    public class InputGetAccessToken(int userId, int durationTokenInMinutes, string key)
    {
        public InputGetAccessToken(int userId, string key) : this(userId, 60 * 24 * 7, key)
        {

        }
        public int UserId { get; } = userId;
        public int DurationTokenInMinutes { get; } = durationTokenInMinutes;
        public string Key { get; } = key;
    }
}
