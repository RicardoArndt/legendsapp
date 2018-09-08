using Solution.Database.Entities.Champions;
using Solution.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.REST.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
        }

        private static void Add()
        {
            using (var champ = new ChampionRepository())
            {
                new List<Champion>
                {
                    new Champion("Jax", true) {},
                    new Champion("Orianna", true) {},
                    new Champion("Ekko", true) {}
                }.ForEach(champ.Add);

                champ.SaveAll();

                System.Console.WriteLine("Campeões adicionadas com sucesso.");

                System.Console.WriteLine("=======  clientes cadastrados ===========");
                foreach (var c in champ.GetAll())
                {
                    System.Console.WriteLine("{0} - {1}", c.Id, c.Name);
                }

                System.Console.ReadKey();
            }
        }
    }
}
