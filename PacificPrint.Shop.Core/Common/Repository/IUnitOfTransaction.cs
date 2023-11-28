using System;
using System.Threading;
using System.Threading.Tasks;

namespace PacificPrint.Shop.Core.Common_Repository
{
    public interface IUnitOfTransaction : IDisposable
    {
        bool SupportsSavepoints { get; }
        Task CreateSavepointAsync(string name, CancellationToken cancellationToken = default);
        Task RollbackToSavepointAsync(string name, CancellationToken cancellationToken = default);
        Task ReleaseSavepointAsync(string name, CancellationToken cancellationToken = default);

        Task CommitAsync(CancellationToken cancellationToken = default);
        Task RollbackAsync(CancellationToken cancellationToken = default);
    }
}
