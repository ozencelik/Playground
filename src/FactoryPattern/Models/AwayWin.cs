using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class AwayWin : ISoccer
    {
        public ISoccer Outcome(int homeScore, int awayScore)
        {
            return awayScore > homeScore
                ? (ISoccer)Activator.CreateInstance(
                    Type.GetType($"FactoryPattern.Models.{nameof(AwayWin)}")) : null;
        }

        public void Print()
        {
            Console.WriteLine("Away team wins ");
        }
    }
}
