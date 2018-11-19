using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockManager.Data;
using StockManager.Models;


namespace StockManager.Repositories
{
    public class PrendaRepository : GenericRepository<Prenda>, IPrendaRepository
    {
        public PrendaRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
