using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Away3Home0 : ISoccer
    {
        public ISoccer Outcome(int homeScore, int awayScore)
        {
            return awayScore == 3 && homeScore == 0
                ? (ISoccer)Activator.CreateInstance(
                    Type.GetType($"FactoryPattern.Models.{nameof(Away3Home0)}")) : null;

        }

        public void Print()
        {
            Console.WriteLine("Rakip takım, ev sahibi takımını 3:0 yendi.");
        }
    }
}