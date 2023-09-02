namespace HR.EMS.Application.StaticHelpers;

public static class StaticHelpers
{
    public static string ReadStream(Stream stream)
    {
        using var reader = new StreamReader(stream, Encoding.UTF8);
        return reader.ReadToEnd();
    }
}
