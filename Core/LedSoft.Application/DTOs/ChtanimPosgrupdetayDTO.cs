using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class ChtanimPosgrupdetayDTO
    {
        public long Id { get; set; }

        public long? Posgrupid { get; set; }

        public long? Chid { get; set; }

        public bool? Aktif { get; set; }
    }
}
