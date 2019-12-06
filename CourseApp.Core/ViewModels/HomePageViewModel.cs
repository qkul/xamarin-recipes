using CourseApp.Core.Data;
using CourseApp.Core.Infarstructure;
using CourseApp.Core.Models;
using CourseApp.Core.Service;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Core
{
	public class HomePageViewModel : MvxViewModel
	{
		INavigationManager _navigationManager;
		private IEnumerable<Dishes> _dishes;
		RecipesLocalRepository  _recipesLocalService;

		public IMvxCommand NavigateToCityAsyncCommand => new MvxAsyncCommand<Dishes>(DoNavigateToRecipesAsync);
		public HomePageViewModel()
		{
			//_navigationManager = navigationService;
		}
		public override Task Initialize()
		{
			// Async initialization, YEY!

			return base.Initialize();
		}
		public IEnumerable<Dishes> Dishes
		{
			get => _dishes;
			set
			{
				_dishes = value;
				RaisePropertyChanged(() => Dishes);
			}
		}

		public override  void ViewCreated()
		{
			base.ViewCreated();
		//	Dishes =  _recipesLocalService.GetAll();
		}
		private async Task DoNavigateToRecipesAsync(Dishes dishes)
		{
			await _navigationManager.NavigateToRecipesAsync(dishes);
		}
	}
}
