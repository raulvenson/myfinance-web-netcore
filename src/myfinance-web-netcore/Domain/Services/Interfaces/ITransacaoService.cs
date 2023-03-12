using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Domain.Services.Interfaces
{
    public interface ITransacaoService
    {
       List<TransacaoModel> ListarRegistros();

       void Salvar(TransacaoModel model);

       TransacaoModel RetornarRegistro(int id);

       void Excluir(int id);
    }
}