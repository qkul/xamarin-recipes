using CourseApp.Core.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp.Core.Data
{
	public class RecipesLocalRepository
	{
		private string _dbPath;

		public RecipesLocalRepository(string dbPath)
		{
			_dbPath = dbPath;
			using (var _db = new SQLiteConnection(_dbPath))
			{
				_db.CreateTable<Recipes>();
			}
		}

		public void Save(Dishes recipes)
		{
			using (var _db = new SQLiteConnection(_dbPath))
			{
				_db.InsertOrReplace(recipes);
			}
		}

		public IEnumerable<Dishes> GetAll()
		{
			using (var _db = new SQLiteConnection(_dbPath))
			{
				return _db.Table<Dishes>().ToList();
			}
		}

		public void Delete(int id)
		{
			using (var _db = new SQLiteConnection(_dbPath))
			{
				_db.Delete<Recipes>(id);
			}
		}

		public void DeleteAll()
		{
			using (var _db = new SQLiteConnection(_dbPath))
			{
				_db.DeleteAll<Recipes>();
			}
		}
	}
}
