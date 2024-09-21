using AzRefArc.AspNetBlazorUnited.Resources;
using System.ComponentModel.DataAnnotations;

namespace AzRefArc.AspNetBlazorUnited.Components.Pages
{
    [CustomValidation(typeof(FormTestViewModel), "NameAndPhoneCheck")]
    public class FormTestViewModel
    {
        [Display(Name = "著者名（名）")]
        // [Required(ErrorMessage = "著者名（名）は必須入力です。")]
        [Required(ErrorMessageResourceName = "RequiredError", ErrorMessageResourceType = typeof(SharedResources))]
        [StringLength(20, ErrorMessageResourceName = "MaxLengthError", ErrorMessageResourceType = typeof(SharedResources))]
        public string AuthorFirstName { get; set; } = String.Empty;

    }
}
