using ExpressoPizza.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ExpressoPizza.Infra.Data.Repositorio
{
    public class PizzaRepositorio
    {
        private static List<Pizza> Pizzas = new List<Pizza>();

        public void Adicionar(Pizza pizza)
        {
            pizza.PizzaId = ObterMaxId();
            PizzaRepositorio.Pizzas.Add(pizza);
        }

        public Pizza Obter(int pizzaId)
        {
            return PizzaRepositorio.Pizzas.FirstOrDefault(i => i.PizzaId == pizzaId);
        }

        public List<Pizza> ObterTodos()
        {
            return PizzaRepositorio.Pizzas;
        }

        public List<Pizza> ObterPizzas(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                return ObterTodos();
            return PizzaRepositorio.Pizzas.Where(c => c.Nome.StartsWith(nome)).ToList();
        }

        public int ObterMaxId()
        {
            return PizzaRepositorio.Pizzas.Count() > 0 ? PizzaRepositorio.Pizzas.Max(p => p.PizzaId) + 1 : 0;
        }
    }
}