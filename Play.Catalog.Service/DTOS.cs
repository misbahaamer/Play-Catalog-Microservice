﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Catalog.Service
{
    public record ItemDTO
    (
        Guid Id,
        string Name,
        string Description,
        decimal Price,
        DateTimeOffset CreatedDate
    );

    public record CreateItemDTO
    (
        string Name,
        string Description,
        decimal Price
    );

    public record UpdateItemDTO
    (
        string Name,
        string Description,
        decimal Price
    );

}

