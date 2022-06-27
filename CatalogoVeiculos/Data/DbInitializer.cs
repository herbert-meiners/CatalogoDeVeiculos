using CatalogoVeiculos.Models;
using System;
using System.Linq;

namespace CatalogoVeiculos.Data
{
    public static class DbInitializer
    {
        public static void Initialize(VeiculoContext context)
        {
            context.Database.EnsureCreated();

            if (context.Veiculos.Any())
            {
                return;
            }

            var veiculo = new Veiculo[]
            {
            new Veiculo{Placa="AAA1234", Renavam="59235648-12", Nome="João do Caminhão", CPF="11100022245", Bloqueado=true, Imagem=null},
            new Veiculo{Placa="ABC0123", Renavam="30652384-9", Nome="Maria da Belina", CPF="33300066677", Bloqueado=false, Imagem=null},
            };
            foreach (Veiculo v in veiculo)
            {
                context.Veiculos.Add(v);
            }
            context.SaveChanges();           
        }
    }
}