﻿using System.ComponentModel.DataAnnotations;

namespace AppMvcBasica.Models
{
    public class Endereco : Entity
    {
        public Guid? FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")] //O parametro {0} é a propriédade
        [StringLength(200, MinimumLength = 2, ErrorMessage = "O campo {0} precisar ter entre {2} e {1} caracteres.")]
        public string? Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")] 
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo {0} precisar ter entre {2} e {1} caracteres.")]
        public string? Numero { get; set; }
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")] 
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O campo {0} precisar ter entre {2} e {1} caracteres.")]
        public string? Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")] 
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo {0} precisar ter entre {2} e {1} caracteres.")]
        public string? Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")] 
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo {0} precisar ter entre {2} e {1} caracteres.")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo {0} precisar ter entre {2} e {1} caracteres.")]
        public string? Estado { get; set; }

        public Fornecedor? Fornecedor { get; set; }
    }
}
