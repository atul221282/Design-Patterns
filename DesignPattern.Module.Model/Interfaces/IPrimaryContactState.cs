﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Module.Model.Interfaces
{
    public interface IPrimaryContactState
    {
        IPrimaryContactState Set(IContactInfo contact);
        IContactInfo Get();
    }
}
