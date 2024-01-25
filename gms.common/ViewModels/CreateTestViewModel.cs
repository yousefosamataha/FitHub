using System.ComponentModel.DataAnnotations;

namespace gms.common.ViewModels;
public class CreateTestViewModel
{
    [Display(Name = "name"), Required(ErrorMessage = "required")]
    public string Name { get; set; }
}
