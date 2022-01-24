using System.ComponentModel.DataAnnotations;

namespace Swashbuckle.AspNetCore.TestSupport
{
    public record RecordWithValidationAttributes(
            [DataType(DataType.CreditCard)]
            string StringWidthDataTypeCreditCard,
            [MinLength(1), MaxLength(3)]
            string StringWithMinMaxLength,
            [MinLength(1), MaxLength(3)]
            string[] ArrayWithMinMaxLength,
            [Range(1, 10)]
            int IntWithRange,
            [RegularExpression("^[3-6]?\\d{12,15}$")]
            string StringWithRegularExpression,
            [StringLength(10, MinimumLength = 5)]
            string StringWithStringLength,
            [Required]
            string StringWithRequired);
}