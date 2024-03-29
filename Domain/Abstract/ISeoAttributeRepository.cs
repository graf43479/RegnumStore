﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Abstract
{
    public interface ISeoAttributeRepository
    {
        IQueryable<SeoAttribute> SeoAttributes { get; }

        void SaveSeoAttributes(SeoAttribute seoAttribute);

        void DeleteSeoAttributes(SeoAttribute seoAttribute);


    }
}
