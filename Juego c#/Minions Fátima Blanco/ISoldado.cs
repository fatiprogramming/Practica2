using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minions_Fátima_Blanco
{
    public interface ISoldado
    { 
        public List<IArma> Arsenal { get; set; }
    }
}
