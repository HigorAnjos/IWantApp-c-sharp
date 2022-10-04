﻿using IWantApp.Domain.Products;
using IWantApp.Properties.Infra.Data;

namespace IWantApp.Endpoints.Categories
{
    public class CategoryGetAll
    {
        public static string Template => "/categories";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(ApplicationDbContext context)
        {
            var categories = context.Categories.ToList();
            var response = categories.Select(item => new CategoryResponse { Id = item.Id, Name = item.Name, Active = item.Active });

            return Results.Ok(response);
        }
    }
}
