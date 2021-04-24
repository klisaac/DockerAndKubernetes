﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Microservice.Api1.Core.Specifications.Base
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        bool IsDeleted { get; }
        int Take { get; }
        int Skip { get; }
        bool isPagingEnabled { get; }
    }
}
