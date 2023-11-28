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
    public class UserService : EntityServiceBase<User, Guid>, IUserService
    {
        private readonly ICurrentUser _currentUser;

        public UserService(IUnitOfWork unitOfWork, ICurrentUser currentUser) : base(unitOfWork)
        {
            _currentUser = currentUser;
        }
    }
}
