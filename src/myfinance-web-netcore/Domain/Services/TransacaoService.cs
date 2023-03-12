using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Domain.Entities;
using myfinance_web_netcore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace myfinance_web_netcore.Domain.Services.Interfaces
{
    public class TransacaoService : ITransacaoService
    {

        private readonly MyFinanceDbContext _dbContext;


        public TransacaoService(MyFinanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TransacaoModel> ListarRegistros()
        {
            var result = new List<TransacaoModel>();
            var dbSet = _dbContext.Transacao.Include( x => x.PlanoConta);

            foreach (var item in dbSet)
            {
                var itemPlanoConta = new TransacaoModel()
                {
                    Id = item.Id,
                    Historico = item.Historico,
                    Data = item.Data,
                    Valor = item.Valor,
                    ItemPlanoConta = new PlanoContaModel(){
                        Id = item.PlanoConta.Id,
                        Descricao = item.PlanoConta.Descricao,
                        Tipo = item.PlanoConta.Tipo
                    },
                    PlanoContaId = item.PlanoContaId
                };

                result.Add(itemPlanoConta);
            }


            return result;
        }

        public void Salvar(TransacaoModel model)
        {

            var dbSet = _dbContext.Transacao;

            var entidade = new Transacao()
            {
                Id = model.Id,
                Historico = model.Historico,
                Data = model.Data,
                Valor = model.Valor,
                PlanoContaId = model.PlanoContaId
            };

            if (entidade.Id == null)
            {
                dbSet.Add(entidade);
            }
            else
            {
                dbSet.Attach(entidade);
                _dbContext.Entry(entidade).State = EntityState.Modified;
            }

            _dbContext.SaveChanges();
        }

        public TransacaoModel RetornarRegistro(int id)
        {
            var item = _dbContext.Transacao.Where(x => x.Id == id).First();

            var itemPlanoConta = new TransacaoModel()
            {
                Id = item.Id,
                Historico = item.Historico,
                Data = item.Data,
                Valor = item.Valor,
                PlanoContaId = item.PlanoContaId,
                
            };

            return itemPlanoConta;
        }

        public void Excluir(int id)
        {

            var item = _dbContext.Transacao.Where(x => x.Id == id).First();

            _dbContext.Attach(item);
            _dbContext.Remove(item);
            _dbContext.SaveChanges();

        }

    }
}