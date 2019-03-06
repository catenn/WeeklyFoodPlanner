﻿using System;
using System.Collections.Generic;

namespace WeeklyFoodPlanner.Models
{
    public class HelperEnums
    {
        public enum QuantityType
        {
            Bags,
            Bottles,
            Blocks,
            Boxes,
            Cartons,
            Cups,
            Containers,
            Gallons,
            Liters,
            Ounces,
            Kilograms,
            Pounds,
            Tablespoons,
            Teaspoons
        };

        public enum MealType
        {
            Breakfast,
            Snack1,
            Lunch,
            Snack2,
            Dinner,
            PreWorkout,
            PostWorkout
        };
    }
}