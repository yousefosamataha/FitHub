using Microsoft.Extensions.Localization;
using Newtonsoft.Json;

namespace gms.common.Localization;
public class JsonStringLocalizer : IStringLocalizer
{
    private readonly JsonSerializer _serializer = new();
    public LocalizedString this[string name]
    {
        get => new LocalizedString(name, GetString(name));
    }

    public LocalizedString this[string name, params object[] arguments]
    {
        get
        {
            var actualvalue = this[name];
            return !actualvalue.ResourceNotFound ? new LocalizedString(name, string.Format(actualvalue.Value, arguments)) : actualvalue;
        }
    }

    public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
    {
        string? fullFilePath = Path.GetFullPath($"Resources/{Thread.CurrentThread.CurrentCulture.Name}.json");

        using FileStream stream = new(fullFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        using StreamReader streamReader = new(stream);
        using JsonTextReader reader = new(streamReader);

        while (reader.Read())
        {
            if (reader.TokenType != JsonToken.PropertyName)
                continue;

            string? key = reader.Value as string;
            reader.Read();

            string? value = _serializer.Deserialize<string>(reader);
            yield return new LocalizedString(key, value);
        }

    }
    private string GetString(string key)
    {
        string? fullFilePath = Path.GetFullPath($"Resources/{Thread.CurrentThread.CurrentCulture.Name}.json");
        return File.Exists(fullFilePath) ? GetStringFromJson(key, fullFilePath) : string.Empty;
    }
    private string GetStringFromJson(string key, string filePath)
    {
        if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(filePath))
            return string.Empty;

        using FileStream stream = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        using StreamReader streamReader = new(stream);
        using JsonTextReader reader = new(streamReader);


        while (reader.Read())
        {
            if (reader.TokenType == JsonToken.PropertyName && reader.Value as string == key)
            {
                reader.Read();
                return _serializer.Deserialize<string>(reader);
            }
        }
        return string.Empty;
    }
}
