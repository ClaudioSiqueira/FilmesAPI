using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Entities
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("O título não pode ser vazio")
                .Length(1, 50).WithMessage("O título deve ter entre 1 e 50 caracteres");
            RuleFor(x => x.Director)
                .NotEmpty().WithMessage("O diretor não pode ser vazio")
                .Length(1, 50).WithMessage("O diretor deve ter entre 1 e 50 caracteres");
            RuleFor(x => x.Genre)
                .NotEmpty().WithMessage("O genero não pode ser vazio")
                .Length(1, 50).WithMessage("O genero deve ter entre 1 e 50 caracteres");
            RuleFor(x => x.Duration)
                .NotEmpty().WithMessage("A duração não pode ser vazia")
                .InclusiveBetween(1, 500).WithMessage("A duração não deve ser maior que 500 minutos");

        }
    }
}
