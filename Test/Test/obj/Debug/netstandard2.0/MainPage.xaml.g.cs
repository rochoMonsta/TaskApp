//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Test.MainPage.xaml", "MainPage.xaml", typeof(global::Test.MainPage))]

namespace Test {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("MainPage.xaml")]
    public partial class MainPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfKanban.XForms.SfKanban kanban;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfKanban.XForms.KanbanColumn openColumn;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfKanban.XForms.KanbanColumn progressColumn;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfKanban.XForms.KanbanColumn codeColumn;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Syncfusion.SfKanban.XForms.KanbanColumn doneColumn;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MainPage));
            kanban = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfKanban.XForms.SfKanban>(this, "kanban");
            openColumn = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfKanban.XForms.KanbanColumn>(this, "openColumn");
            progressColumn = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfKanban.XForms.KanbanColumn>(this, "progressColumn");
            codeColumn = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfKanban.XForms.KanbanColumn>(this, "codeColumn");
            doneColumn = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Syncfusion.SfKanban.XForms.KanbanColumn>(this, "doneColumn");
        }
    }
}
