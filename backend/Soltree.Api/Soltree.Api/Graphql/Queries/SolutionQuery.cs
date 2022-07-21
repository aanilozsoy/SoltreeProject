﻿using Soltree.Api.Data;
using Soltree.Api.Data.Etities;

namespace Soltree.Api.Graphql.Queries
{
    [ExtendObjectType((typeof(Query)))]
    public class SolutionQuery
    {
        [UseOffsetPaging]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Solution> GetSolutions([Service] AppDbContext context)
        {
            return context.Solutions;
        }
    }
}
