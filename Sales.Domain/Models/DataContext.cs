﻿using System.Data.Entity;

namespace Sales.Domain.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
    }
}
