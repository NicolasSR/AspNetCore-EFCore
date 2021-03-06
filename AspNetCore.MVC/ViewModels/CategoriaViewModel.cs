﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AspNetCore.MVC.ViewModels
{
    [DataContract]
    public class CategoriaViewModel
    {
        public CategoriaViewModel()
        {
            this.DataCadastro = DateTime.Now;
        }

        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Descrição")]
        [MinLength(4, ErrorMessage = "Campo deve ter no mínimo 4 caracteres")]
        [MaxLength(100, ErrorMessage = "Campo deve ter no máximo 100 caracteres")]
        [DisplayName("Descrição")]
        [DataMember]
        public string Descricao { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        [DisplayName("Data de Cadastro")]
        [DataMember]
        public DateTime DataCadastro { get; set; }
    }
}
