using CourseApp.Core.Models;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp.Core.ViewModels
{
	public class RecipesViewModel : MvxViewModel<Dishes>
	{
		Dishes _dishes;
		public Dishes Dishes
		{
			get => _dishes;
			set
			{
				_dishes = value;
				RaisePropertyChanged(() => Dishes);
			}
		}
		public override void Prepare(Dishes parameter)
		{
			_dishes = parameter;
		}
	}
}
