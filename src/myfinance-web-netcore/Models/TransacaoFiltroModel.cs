using Microsoft.AspNetCore.Mvc.Rendering;
using myfinance_web_netcore.Domain.Entities;

namespace myfinance_web_netcore.Models
{
    public class TransacaoFiltroModel{
    
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    
    }
}