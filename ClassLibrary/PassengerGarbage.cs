using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    [BsonIgnoreExtraElements]
    public class PassengerGarbage
    {
        public String CPF { get; set; }
        public String Name { get; set; }
        public Address Address { get; set; }
    }

}
