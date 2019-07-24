namespace Trestlebridge.Interfaces
{
    public interface IGrazing
    {
        double FeedPerDay { get; set; }
        void Graze();

        string Type { get; }
    }
}