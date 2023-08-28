using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class HomeWin : ISoccer
    {
        public ISoccer Outcome(int homeScore, int awayScore)
        {
            return homeScore > awayScore
                ? (ISoccer)Activator.CreateInstance(
                    Type.GetType($"FactoryPattern.Models.{nameof(HomeWin)}")) : null;
        }

        public void Print()
        {
            Console.WriteLine("Home team wins ");
        }
    }
}
