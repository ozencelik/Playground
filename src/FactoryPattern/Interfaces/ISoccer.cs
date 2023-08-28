namespace FactoryPattern.Interfaces
{
    public interface ISoccer
    {
        ISoccer Outcome(int homeScore, int awayScore);
        void Print();
    }
}
