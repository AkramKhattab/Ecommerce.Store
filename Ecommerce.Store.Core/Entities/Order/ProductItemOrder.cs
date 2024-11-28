using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Core.Entities.Order
{
    public class ProductItemOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public object ProductName { get; internal set; }
        public object ProductId { get; internal set; }

        public ProductItemOrder(int id, string name, string pictureUrl)
        {
            Id = id;

            Name = name;

            PictureUrl = pictureUrl;
        }
    }

}
