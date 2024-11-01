using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FiyatlisteCarikategoriDTO
    {
        public long Id { get; set; }

        public long? Fiyatlisteid { get; set; }

        public string? Kategoritip { get; set; }

        public long? Kategoriid { get; set; }
    }
}
