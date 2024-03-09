using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpShared.Domain.Utils
{
    public interface UseCase<in T, out K>
    {
        K Execute(T entity);
    }
}
