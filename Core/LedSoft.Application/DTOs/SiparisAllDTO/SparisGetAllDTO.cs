using LedSoft.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs.SiparisAllDTO
{
    public class SparisGetAllDTO
    {
        public Sipari Siparies { get; set; }
        public SiparisDeger SiparisDegers { get; set; }
        public SiparisDetay SiparisDetays { get; set; }
     
    }
}
