namespace KataPotter.Infrastructure;

public class InMemoryClient : IClient
{
    public decimal Get(int book) => book switch
    {
        2 => 0.95m,
        3 => 0.9m,
        4 => 0.8m,
        5 => 0.75m,
        _ => 1m
    };
}