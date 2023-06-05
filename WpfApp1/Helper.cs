using WpfApp1.Models;
namespace WpfApp1;

public class Helper
{
    private static RkisContext _db;

    public static RkisContext GetContext()
    {
        if (_db == null)
        {
            _db = new RkisContext();
        }

        return _db;
    }
}