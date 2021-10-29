using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Blokitect.Data.Framework;
using Blokitect.Data.Models;

namespace Blokitect.Data.Services
{
    /// <summary>
    /// A representation of a service which uses the CRUD-methods
    /// </summary>
    /// <typeparam name="TM"> TypeModel </typeparam>
    /// <typeparam name="TVM"> TypeViewModel </typeparam>
    /// <typeparam name="TCVM"> TypeCreateViewModel </typeparam>
    /// <typeparam name="TEVM"> TypeEditViewModel </typeparam>
    public interface ICrudService<TM, TVM, TCVM, TEVM>
        where TM : IMapFrom<TVM>, IMapFrom<TCVM>, IMapFrom<TEVM> 
        where TVM : IMapFrom<TM>
        where TCVM : TVM
        where TEVM : TCVM
    {
        TCVM Create();

        Task<ServiceOperationResult> Create(TCVM viewModel);

        Task<IList<TVM>> ReadAll();

        Task<TVM> ReadById(long id);

        TEVM Update();

        Task<ServiceOperationResult> Update(long id, TEVM viewModel);

        Task<ServiceOperationResult> Delete(long id, TVM viewModel);
    }
}
