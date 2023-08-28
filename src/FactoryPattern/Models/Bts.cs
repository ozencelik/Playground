using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Bts : ISoccer
    {
        public ISoccer Outcome(int homeScore, int awayScore)
        {
            return awayScore > 0 && homeScore > 0
                ? (ISoccer)Activator.CreateInstance(
                    Type.GetType($"FactoryPattern.Models.{nameof(Bts)}")) : null;
        }

        public void Print()
        {
            Console.WriteLine("Both team scored ");
        }
    }
}
