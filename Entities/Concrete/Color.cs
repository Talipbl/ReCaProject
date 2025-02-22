﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color :IEntity
    {
        public int ColorID { get; set; }
        public string ColorName { get; set; }

        public virtual List<Car> Cars { get; set; }
    }
}
