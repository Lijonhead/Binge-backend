﻿namespace GenerateDishesAPI.Models
{
	public class Recipe
	{
		public int Id { get; set; }
		public string Instructions { get; set; }

		public int DishId { get; set; }
		public virtual Dish dish { get; set; } = null!;
	}
}
