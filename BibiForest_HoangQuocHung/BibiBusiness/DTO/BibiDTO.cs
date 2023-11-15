using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibiBusiness.DTO
{
    public class BibiDTO
    {
        public int BibiId { get; set; }

        public string Password { get; set; } = null!;

        public string BibiName { get; set; } = null!;

        public string Food { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string Forest { get; set; } = null!;
        public string OwnerName { get; set; } = null!;
    }
}
