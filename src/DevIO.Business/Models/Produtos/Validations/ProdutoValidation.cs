using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Produtos.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(c => c.Nome)
                   .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                   .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {Minlength} e {Maxlength} caracteres");

            RuleFor(c => c.Descricao)
                   .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                   .Length(2, 1000).WithMessage("O campo {PropertyName} precisa ter entre {Minlength} e {Maxlength} caracteres");

            RuleFor(c => c.Valor)
                   .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                   .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ter entre {Minlength} e {Maxlength} caracteres");
        }
    }
}
