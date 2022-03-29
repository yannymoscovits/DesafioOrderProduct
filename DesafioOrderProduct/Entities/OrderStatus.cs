using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioOrderProduct.Entities
{
    enum OrderStatus : int
    {
       PENDING_PAYMANT = 0,
       PROCESSING = 1,
       SHIPPED = 2,
       DELIVERY = 3,


    }
}
