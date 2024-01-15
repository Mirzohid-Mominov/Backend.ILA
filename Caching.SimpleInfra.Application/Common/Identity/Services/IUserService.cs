using Caching.SimpleInfra.Domain.Common.Query;
using Caching.SimpleInfra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Caching.SimpleInfra.Application.Common.Identity.Services
{
    public interface IUserService
    {
        IQueryable<User> Get(Expression<Func<User, bool>> predicate = default, bool asNotracking = false);

        ValueTask<IList<User>> GetAsync(QuerySpecification<User> querySpecification,
            bool asNoTracking  = false,
            CancellationToken cancellationToken = default);

        ValueTask<User?> GetByIdAsync(Guid userId, bool asNoTracking = false, CancellationToken cancellationToken = default);


    }
}
