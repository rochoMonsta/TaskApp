using Syncfusion.SfKanban.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Text;

namespace Test
{
	[DataContract]
	class ViewModel
    {
		public ObservableCollection<KanbanModel> Cards { get; set; }
		[DataMember]
		public static ObservableCollection<KanbanModel> CardsCopy = new ObservableCollection<KanbanModel>();
		public ViewModel()
		{
			Cards = CardsCopy;
			//Cards = new ObservableCollection<KanbanModel>();
			//Cards.Add(new KanbanModel()
			//{
			//	ID = 1,
			//	Title = "Написати проект",
			//	ImageURL = "todo.png",
			//	Category = "Виконати",
			//	Description = "Написати проект разом з хлопцями",
			//	ColorKey = "Blue",
			//	Tags = new string[] { "Проект", "Програмування" }
			//});
			//Cards.Add(new KanbanModel()
			//{
			//	ID = 2,
			//	Title = "Проект (сторінка статистики)",
			//	ImageURL = "todo.png",
			//	Category = "Виконати",
			//	Description = "Написати фронтенд сторінки статистики",
			//	ColorKey = "Blue",
			//	Tags = new string[] { "Проект", "Програмування" }
			//});
			//Cards.Add(new KanbanModel()
			//{
			//	ID = 3,
			//	Title = "Оптимізація БД",
			//	ImageURL = "todo.png",
			//	Category = "Виконується",
			//	Description = "Оптимізувати БД для швидкого завантаження",
			//	ColorKey = "Yellow",
			//	Tags = new string[] { "Проект", "Програмування" }
			//});
			//Cards.Add(new KanbanModel()
			//{
			//	ID = 4,
			//	Title = "Основна логіка БД",
			//	Category = "Виконано",
			//	ImageURL = "todo.png",
			//	Description = "Зберігання та завантаження БД",
			//	ColorKey = "Green",
			//	Tags = new string[] { "Проект", "Програмування" }
			//});
		}
	}
}
