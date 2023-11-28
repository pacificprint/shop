using Microsoft.EntityFrameworkCore;
using PacificPrint.Shop.Core.Common_Repository;
using PacificPrint.Shop.Core.Common_Security;
using PacificPrint.Shop.Core.Common;
using PacificPrint.Shop.Core.Contract;
using PacificPrint.Shop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace PacificPrint.Shop.Core.Service
{
    public class ClientService : EntityServiceBase<Client, Guid>, IClientService
    {
        private readonly ICurrentUser _currentUser;

        public ClientService(IUnitOfWork unitOfWork, ICurrentUser currentUser) : base(unitOfWork)
        {
            _currentUser = currentUser;
        }
    }
}
