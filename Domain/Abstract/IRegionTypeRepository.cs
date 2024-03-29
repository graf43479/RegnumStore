﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Abstract
{
    public interface IRegionTypeRepository
    {
        IQueryable<RegionType> RegionTypes { get; }

        void SaveRegionType(RegionType regionType);

        void DeleteRegionType(RegionType regionType);
    }
}
