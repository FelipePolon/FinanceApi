using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Too short. Title must have at least 5 characters")]
        [MaxLength(50, ErrorMessage = "Too big. Title cannot pass 50 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Too short. Content must have at least 5 characters")]
        [MaxLength(280, ErrorMessage = "Too big. Content cannot pass 280 characters")]
        public string Content { get; set; } = string.Empty;
    }
}