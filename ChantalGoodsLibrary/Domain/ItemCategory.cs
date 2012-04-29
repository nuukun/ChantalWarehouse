using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChantalGoodsLibrary.Domain
{

    public class ItemCategory
    {
        public virtual int Id { get; set; }
        public virtual string ItemCode { get; set; }
        public virtual string ItemName { get; set; }
    }
}
