using KataPotter.Domain;

namespace KataPotter.Services;

public interface IPrice
{
    decimal GetTotal(IEnumerable<Book> rawBooks);
}