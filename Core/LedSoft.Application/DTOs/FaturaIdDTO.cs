using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FaturaIdDTO
    {
        public long NewId { get; set; }
        public long OldId { get; set; }

        public long DetayId { get; set; }
    }
}
