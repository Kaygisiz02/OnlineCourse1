using FluentValidation;
using OnlineCourse.Busines;

namespace OnlineCourse.Presentations
{
    public class BlogCategoryValidators:AbstractValidator<BlogCategoryDto>
    {
        public BlogCategoryValidators()
        {
            RuleFor(x => x.BlogCategoryName)
                    .NotEmpty().WithMessage("Blog kategorisi adı boş geçilemez.")
                    .Length(3, 50).WithMessage("Blog kategorisi adı 3 ila 50 karakter arasında olmalıdır.");

            RuleFor(x => x.Description)
                .MaximumLength(200).WithMessage("Açıklama 200 karakteri aşamaz.");
        }
    }
}
