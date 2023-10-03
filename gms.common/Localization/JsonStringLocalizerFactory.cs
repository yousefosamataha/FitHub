using Microsoft.Extensions.Localization;

namespace gms.common.Localization;
public class JsonStringLocalizerFactory : IStringLocalizerFactory
{
    public IStringLocalizer Create(Type resourceSource) => new JsonStringLocalizer();

    public IStringLocalizer Create(string baseName, string location) => new JsonStringLocalizer();
}
