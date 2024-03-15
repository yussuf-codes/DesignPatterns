namespace DesignPatterns.Creational.Singleton;

class DatabaseConnection
{
    private DatabaseConnection() { }
    private static readonly DatabaseConnection Instance = new();
    public static DatabaseConnection GetInstance() => Instance;
}
