using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using PacificPrint.Shop.Core.Common_Repository;
using PacificPrint.Shop.Core.Dal;
using PacificPrint.Shop.Data.Context;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace PacificPrint.Shop.Core.Dal_Repository
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly PacificPrintContext _context;
        private readonly IServiceProvider _provider;

        public UnitOfWork(PacificPrintContext context, IServiceProvider provider)
        {
            _context = context;
            _provider = provider;
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return _provider.GetRequiredService<IRepository<TEntity>>();
        }

        public async Task<IUnitOfTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            var transaction = await _context.Database.BeginTransactionAsync(cancellationToken);

            return new UnitOfTransaction(transaction);
        }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}