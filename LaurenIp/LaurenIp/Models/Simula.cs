using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaurenIp.Models
{
    public class Simula
    {

        [Key]
        public int IdCodigo { get; set; }

        [Required]
        [MaxLength(100)]
        public string NomeProjeto { get; set; }


        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DataInico { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DataFinal { get; set; }
        public decimal ValorProjeto { get; set; }
        public RiscoEnum RiscoEnum { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Participantes { get; set; }


    }

    public enum RiscoEnum
    {
        BAIXO = 0,MEDIO =1,ALTO =2
    }
}