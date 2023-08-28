using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Draw : ISoccer
    {
        public ISoccer Outcome(int homeScore, int awayScore)
        {
            return homeScore > 0 && homeScore == awayScore
                ? (ISoccer)Activator.CreateInstance(
                    Type.GetType($"FactoryPattern.Models.{nameof(Draw)}")) : null;
        }

        public void Print()
        {
            Console.WriteLine("Draw ");
        }
    }
}
