﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public interface IItemUpdateQuantityStrategy
    {
        void UpdateQuantity(Item item);
    } 
}
