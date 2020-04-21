using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Test.Views.Forms;
using Syncfusion.SfKanban.XForms;

namespace Test
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            openColumn.Categories = new List<object>() { "Виконати" };
            progressColumn.Categories = new List<object>() { "Виконується" };
            codeColumn.Categories = new List<object>() { "Виконано" };
            doneColumn.Categories = new List<object>() { "В плані виконання" };

            List<KanbanColorMapping> colorModels = new List<KanbanColorMapping>();
            colorModels.Add(new KanbanColorMapping("Green", Color.Green));
            colorModels.Add(new KanbanColorMapping("Red", Color.Red));
            colorModels.Add(new KanbanColorMapping("Aqua", Color.Aqua));
            colorModels.Add(new KanbanColorMapping("Blue", Color.Blue));
            colorModels.Add(new KanbanColorMapping("Yellow", Color.Yellow));
            kanban.ColorModel = colorModels;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewMission());
        }

        private void kanban_DragEnd(object sender, KanbanDragEndEventArgs e)
        {
            int index = Convert.ToInt32((e.Data as KanbanModel).ID - 1);
            ViewModel.CardsCopy[index].Category = e.TargetCategory;
            //DBSaverLoader dBSaverLoader = new DBSaverLoader();
            //dBSaverLoader.SAVE_USER(ViewModel.CardsCopy);
        }
    }
}
