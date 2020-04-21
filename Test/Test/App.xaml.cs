using Syncfusion.SfKanban.XForms;
using System;
using System.Collections.ObjectModel;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
    public partial class App : Application
    {
        public App()
        {
            //License Key
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQzMzg4QDMxMzgyZTMxMmUzME04UFpEaGZSZlBPcXpBaVBFS0ZBbFFPNVJXbkFVcEtvNnNBWlBlOXhNaEE9");

            InitializeComponent();
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, "ExercisesList.json");
            if(File.Exists(path))
            {
                DBSaverLoader dBSaverLoader = new DBSaverLoader();
                try
                {
                    ViewModel.CardsCopy = dBSaverLoader.LOAD_USER();
                }
                catch (Exception) { }
            }
            else
            {
                ViewModel.CardsCopy = new ObservableCollection<KanbanModel>();
            }

            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            DBSaverLoader dBSaverLoader = new DBSaverLoader();
            dBSaverLoader.SAVE_USER(ViewModel.CardsCopy);
        }

        protected override void OnResume()
        {
        }
    }
}
