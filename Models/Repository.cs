using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Repository : IRepository
    {
        private Dictionary<string, Dron> drons;
        public Repository()
        {
            drons = new Dictionary<string, Dron>();

            drons.Add("1", new Dron {Id=1, Name = "Fresh-whole-fish", Sky= 4420, Price = 99M });

            drons.Add("2", new Dron { Id = 2, Name = "Vegetable-healthy", Sky = 4421, Price = 29.99M });

            drons.Add("3", new Dron { Id = 3, Name = "Raw-onions-surface", Sky = 4422, Price = 40.5M });
            drons.Add("4", new Dron { Id = 4, Name = "Oversize Cotton Dress", Sky = 4424, Price = 40.5M });
        }

        public List<Dron> Drons()
        {
            return drons.Values.ToList();
        }
    }

    public class NewRepository : IRepository
    {
        private Dictionary<string, Dron> drons;
        public NewRepository()
        {
            drons = new Dictionary<string, Dron>();

            drons.Add("1", new Dron { Id = 1, Name = "Fresh-whole-fish", Sky = 4420, Price = 99M });

            drons.Add("2", new Dron { Id = 2, Name = "Vegetable-healthy", Sky = 4421, Price = 29.99M });

            drons.Add("3", new Dron { Id = 3, Name = "Raw-onions-surface", Sky = 4422, Price = 40.5M });
            drons.Add("4", new Dron { Id = 4, Name = "Oversize Cotton Dress", Sky = 4424, Price = 40.5M });
        }

        public List<Dron> Drons()
        {
            return drons.Values.ToList();
        }
    }
}
