using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Repositories.Base
{
    public interface IPage<out T>
    {
        IEnumerable<T> Items { get; }

        int TotalCount { get; }

        int PageIndex { get; }

        int PageSize { get; }

        int TotalPagesCount { get; }
    }
}
