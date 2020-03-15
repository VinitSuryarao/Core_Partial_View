using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial_View.Models
{
    public class ClientModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ClientCommunication ClientCommunication { get; set; }
        public ClientLogin ClientLogin { get; set; }
    }
}
