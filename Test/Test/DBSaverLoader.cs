using Syncfusion.SfKanban.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Test
{
    class DBSaverLoader
    {
        public void SAVE_USER(ObservableCollection<KanbanModel> missions_list)
        {
            var json_formatter = new DataContractJsonSerializer(typeof(ObservableCollection<KanbanModel>));
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var path = Path.Combine(documentsPath, "ExercisesList.json");

            using (var file = new FileStream(path, FileMode.Create))
                json_formatter.WriteObject(file, missions_list);
        }
        public ObservableCollection<KanbanModel> LOAD_USER()
        {
            var json_formatter = new DataContractJsonSerializer(typeof(ObservableCollection<KanbanModel>));

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var path = Path.Combine(documentsPath, "ExercisesList.json");

            using (var file = new FileStream(path, FileMode.OpenOrCreate))
            {
                var missions_list = json_formatter.ReadObject(file) as ObservableCollection<KanbanModel>;
                if (missions_list != null)
                    return missions_list;
            }
            return null;
        }
    }
}
