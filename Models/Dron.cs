using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Dron
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Barcode { get; set; }
        public int Sky {  get; set; }
        public string Type { get; set; }
        public int Quantity {  get; set; }
        public decimal Price { get; set; }
        public decimal Discountwithprice {  get; set; }
    }
}
