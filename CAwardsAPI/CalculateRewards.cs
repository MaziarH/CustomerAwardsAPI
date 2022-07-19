namespace CAwardsAPI
{
    public class CalculateRewards
    {
        public int GetRewards(double amount)
        {
            return (int) Math.Round(amount <= 50.50 ? 0 : (amount - 50 + (amount <= 100.50 ? 0 : amount - 100)));
        }

    }
}
