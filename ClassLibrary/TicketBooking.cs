using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [BsonIgnoreExtraElements]
    public class TicketBooking
    {
        [Required(ErrorMessage = "O campo Voo é obrigatório!")]
        public Flighty Flighty { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório!")]
        public decimal ValueReservation { get; set; }

        [Required(ErrorMessage = "O campo Pagamento em Milhas é obrigatório!")]
        public bool PaymentMilhas { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório!")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "CPF inválido!")]
        public String CPF { get; set; }

        [Required(ErrorMessage = "O campo Pagamento em Dinheiro é obrigatório!")]
        public bool PaymentMoney { get; set; }


    }
}
