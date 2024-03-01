using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace gms.web.Controllers;
public class BaseController<T> : Controller where T : BaseController<T>
{
	#region Private
	private ILogger<T>? _logger;
	private IStringLocalizer<T>? _localizer;
	#endregion

	#region Protected
	protected ILogger<T>? logger =>
		_logger ?? HttpContext.RequestServices.GetRequiredService<ILogger<T>>();

	protected IStringLocalizer<T>? localizer =>
		_localizer ?? HttpContext.RequestServices.GetRequiredService<IStringLocalizer<T>>();
	#endregion
}
