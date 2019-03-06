﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeklyFoodPlanner.Models;

namespace WeeklyFoodPlanner.Services
{
    public class MockDataStore : IDataStore<Recipe>
    {
        List<Recipe> recipes;

        public MockDataStore()
        {
            recipes = new List<Recipe>();
            var mockRecipes = new List<Recipe>
            {
                new Recipe { Id = 1, Name = "Breakfast Quiche", Description="Sausage, egg, and spinach.", Ingredients = new List<Ingredient>
                    {
                        new Ingredient {  }
                    }
                },
                new Recipe { Id = 2, Name = "White Bean Soup", Description="White beans in soup." },
                new Recipe { Id = 3, Name = "Garlic Honey Salmon", Description="Pan seared salmon." }
            };

            foreach (var recipe in mockRecipes)
            {
                recipes.Add(recipe);
            }
        }

        public async Task<bool> AddItemAsync(Recipe item)
        {
            recipes.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Recipe item)
        {
            var oldItem = recipes.Where((Recipe arg) => arg.Id == item.Id).FirstOrDefault();
            recipes.Remove(oldItem);
            recipes.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = recipes.Where((Recipe arg) => arg.Id == id).FirstOrDefault();
            recipes.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Recipe> GetItemAsync(int id)
        {
            return await Task.FromResult(recipes.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Recipe>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(recipes);
        }
    }
}