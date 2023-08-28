using FactoryPattern.Interfaces;

namespace FactoryPattern.Models
{
    public class Soccer
    {
        private static readonly List<ISoccer> SoccerResult = new List<ISoccer>();

        public List<ISoccer> Create(int homeScore, int awayScore)
        {
            var handlers = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => typeof(ISoccer).IsAssignableFrom(p) && p.IsClass);

            foreach (var handler in handlers)
            {
                var handlerInstance = (ISoccer)Activator.CreateInstance(handler);
                var outcome = handlerInstance.Outcome(homeScore, awayScore);

                if (outcome == null)
                    continue;

                SoccerResult.Add(outcome);
            }
            return SoccerResult;
        }
    }
}
