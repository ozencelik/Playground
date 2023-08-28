using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class NegativeResult : ISoccer
    {
        public ISoccer Outcome(int homeScore, int awayScore)
        {
            return awayScore < 0 || homeScore < 0
                ? (ISoccer)Activator.CreateInstance(
                    Type.GetType($"FactoryPattern.Models.{nameof(NegativeResult)}")) : null;
        }

        public void Print()
        {
            Console.WriteLine("Somehow the score is negative. That's not possible");
        }
    }
}
