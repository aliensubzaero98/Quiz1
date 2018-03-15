using System;
using System.Collections.Generic;
using System.Text;

namespace GestorNevera.DataAccess
{
    public class BaseRepository
    {
		private GestorNeveraDBContext Context;
		public BaseRepository()
		{
			this.Context = new GestorNeveraDBContextb();
		}

    }
}
