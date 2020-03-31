using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class NewRentalDto
    {
        public byte Customer_Id { get; set; }
        public List<byte> Movies_Ids { get; set; }
    }
}