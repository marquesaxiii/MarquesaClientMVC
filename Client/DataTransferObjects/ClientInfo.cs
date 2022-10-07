using System;
using System.Collections.Generic;

namespace Client.DataTransferObjects
{
    public partial class ClientInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string MobileNumber { get; set; } = null!;
    }
}
