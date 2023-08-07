using System.Runtime.Serialization.Formatters.Binary;
public static class Cloner
{
    public static T Clone<T>(this T source)
    {
        MemoryStream stream = new MemoryStream();

        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, source);
        return (T)formatter.Deserialize(stream);
    }
}
    class Program
    {

        public static void Main(string[] args)
        {
        var i = Cloner.Clone(typeof(MyClass));

        }
    }
