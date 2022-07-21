﻿using Soltree.Api.Data;
using Soltree.Api.Data.Dtos;
using Soltree.Api.Data.Dtos.SymptomCategory;

namespace Soltree.Api.Graphql.Mutations
{
    public class SymptomCategoryMutation
    {
        public InsertResponse InsertSymptomCategory(SymptomCategoryInsertRequest request, [Service] AppDbContext context)
        {
            var respone = new InsertResponse();
            var symptomcategory = new Data.Etities.SymptomCategory(request.Name);

            context.SymptomCategories.Add(symptomcategory);
            context.SaveChanges();

            respone.Id = symptomcategory.Id;

            return respone;
        }

        public bool UpdateSymptomCategory(SymptomCategoryUpdateRequest request, [Service] AppDbContext context)
        {
            var symptomcategory = context.SymptomCategories.SingleOrDefault(m => m.Id == request.Id);

            if (symptomcategory != null)
            {
                symptomcategory.Name = request.Name;

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool DeleteSymptomCategory(Guid id, [Service] AppDbContext context)
        {
            var symptomcategory = context.SymptomCategories.SingleOrDefault(m => m.Id == id);

            if (symptomcategory != null)
            {
                context.Remove(symptomcategory);
                context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
