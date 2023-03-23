using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    public interface IBag<out T>
    {
        T Get(int id);
    }
}
