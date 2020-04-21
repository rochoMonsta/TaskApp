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
		}
	}
}
