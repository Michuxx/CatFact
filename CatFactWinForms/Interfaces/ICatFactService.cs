using CatFactWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactWinForms.Interfaces
{
    public interface ICatFactService
    {
        Task<CatFactResponse> GetCatFactAsync();
    }
}
