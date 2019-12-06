using CourseApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Core.Infarstructure
{
	public interface INavigationManager
	{
		Task NavigateToRecipe();
		Task NavigateToRecipesAsync(Dishes dishes);
	}
}
