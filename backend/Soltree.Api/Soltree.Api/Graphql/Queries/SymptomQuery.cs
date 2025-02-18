﻿using Soltree.Api.Data;
using Soltree.Api.Data.Entities;

namespace Soltree.Api.Graphql.Queries
{
    [ExtendObjectType("Query")]
    public class SymptomQuery
    {
        [UseOffsetPaging]
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Symptom> GetSymptoms([Service] AppDbContext context)
        {
            return context.Symptoms.AsQueryable();
        }
    }
}
