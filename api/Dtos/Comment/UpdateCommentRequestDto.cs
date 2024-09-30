using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 characters")]
        [MaxLength(280, ErrorMessage = "Title must be less than 280 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Cotent must be 5 characters")]
        [MaxLength(280, ErrorMessage = "Content must be less than 280 characters")]
        public string Content { get; set; } = string.Empty;
    }
}
