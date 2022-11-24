using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ClassLibrary
{
    [BsonIgnoreExtraElements]
    public class Passenger
    {
        [Required(ErrorMessage = "O campo CPF é obrigatório!")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "CPF inválido!")]
        public String CPF { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Número de caracteres excede o limite!!")]
        public String Name { get; set; }

        [Required(ErrorMessage = "O campo Milhas é obrigatório!")]
        public decimal Milhas { get; set; }

        [Required(ErrorMessage = "O campo de reservas é obrigatório!")]
        public List<TicketBooking> Reservations { get; set; }
        public Address Address { get; set; }
    }
}
