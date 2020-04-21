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
        static int StaticID;
        public AddNewMission()
        {
            InitializeComponent();
            StaticID = ViewModel.CardsCopy.Count;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (MissionEntry.Text != "" && DetailMissionEntry.Text != "" && ColorPicker.SelectedIndex != -1)
            {
                ViewModel.CardsCopy.Add(new KanbanModel()
                {
                    ID = StaticID + 1,
                    Title = MissionEntry.Text,
                    Category = "Виконати",
                    Description = DetailMissionEntry.Text,
                    ColorKey = GetColor(),
                    Tags = MissionTagsEntry.Text.Split().ToArray(),
                    ImageURL = GetPicture()
                });
            }
            //DBSaverLoader dBSaverLoader = new DBSaverLoader();
            //dBSaverLoader.SAVE_USER(ViewModel.CardsCopy);
            Navigation.PopAsync();
        }
        private string GetColor()
        {
            switch(ColorPicker.SelectedIndex)
            {
                case 0: return "Green";
                case 1: return "Red";
                case 2: return "Blue";
                case 3: return "Yellow";
            }
            return "Aqua";
        }
        private string GetPicture()
        {
            switch(CategoryPicker.SelectedIndex)
            {
                case 0: return "todo.png";
                case 1: return "cart.png";
                case 2: return "hobby1.png";
                case 3: return "health1.png";
                case 4: return "games1.png";
                case 5: return "knowledge1.png";
                case 6: return "love1.png";
                case 7: return "sport1.png";
            }
            return "todo.png";
        }
    }
}