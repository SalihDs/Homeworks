﻿using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }

    }
}
