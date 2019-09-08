using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models;
using Microsoft.EntityFrameworkCore;

namespace Vendas.Services
{
    public class DepartamentService
    {
        private readonly VendasContext _context;

        public DepartamentService(VendasContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }

}