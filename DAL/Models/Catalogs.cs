﻿using Stock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models;

public class Catalogs
{
    public Guid Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; } = "";


    public  ICollection<Products> Products { get; set; } = new HashSet<Products>();

}
