using System.Collections;

namespace Crude.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double value { get; set; }

        public ArrayList item = new ArrayList();
    }
}
