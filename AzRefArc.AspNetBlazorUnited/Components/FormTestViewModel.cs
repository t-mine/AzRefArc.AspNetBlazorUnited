using AzRefArc.AspNetBlazorUnited.Resources;
using System.ComponentModel.DataAnnotations;

namespace AzRefArc.AspNetBlazorUnited.Components.Pages
{
    [CustomValidation(typeof(FormTestViewModel), "NameAndPhoneCheck")]
    public class FormTestViewModel
    {
        [Display(Name = "著者名（名）")]
        // [Required(ErrorMessage = "著者名（名）は必須入力です。")]
        [Required(ErrorMessageResourceName = "Greeting", ErrorMessageResourceType = typeof(SharedResources))]
        [RegularExpression(@"^[\u0020-\u007e]{1,20}$", ErrorMessage = "著者名（名）は半角 20 文字以内で入力してください。")]
        public string AuthorFirstName { get; set; } = String.Empty;

    }
}
