using CourseApp.Core.Infarstructure;
using CourseApp.Core.Models;
using CourseApp.Core.ViewModels;
using MvvmCross.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Core.Service
{
	public class NavigationManager : INavigationManager
	{
		private readonly IMvxNavigationService _navigationService;

		public NavigationManager(IMvxNavigationService navigationService)
		{
			_navigationService = navigationService;
		}

		public async Task NavigateToRecipesAsync(Dishes dishes)
		{
			await _navigationService.Navigate<RecipesViewModel, Dishes>(dishes);
		}

		public Task NavigateToRecipe()
		{
			throw new NotImplementedException();
		}
	}
}
