using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane

    {
        void Add(Plane p);
        public void Save();
        public IList<Plane> GetAll();
    }
}
