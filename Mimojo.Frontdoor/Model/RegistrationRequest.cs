using System;
using System.Collections.Generic;
using System.Text;

namespace Mimojo.Frontdoor.Model
{
    public class RegistrationRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }
    }
}
