﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Catalog;

public class CatalogDTO
{
    public Guid Id { get; set; }

    public string Name { get; set; } = "";

}
