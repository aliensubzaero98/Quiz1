using GestorNevera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestorNevera.DataAccess
{
    public class SemestreRepository
    {
		public IQueryable<Categoria> Categoria => this.Context.Categoria;
    }
}
