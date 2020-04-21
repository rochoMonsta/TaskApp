using Syncfusion.SfKanban.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewMission : ContentPage
    {
        public AddNewMission()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (MissionEntry.Text != "" && DetailMissionEntry.Text != "" && ColorPicker.SelectedIndex != -1)
            {
                ViewModel.CardsCopy.Add(new KanbanModel()
                {
                    //ID = ViewModel.CardsCopy[ViewModel.CardsCopy.Count - 1].ID + 1,
                    Title = MissionEntry.Text,
                    Category = "Виконати",
                    Description = DetailMissionEntry.Text,
                    ColorKey = ColorPicker.SelectedItem.ToString(),
                    Tags = MissionTagsEntry.Text.Split().ToArray(),
                    ImageURL = "todo.png"
                });
            }
            DBSaverLoader dBSaverLoader = new DBSaverLoader();
            dBSaverLoader.SAVE_USER(ViewModel.CardsCopy);
            Navigation.PopAsync();
        }
    }
}