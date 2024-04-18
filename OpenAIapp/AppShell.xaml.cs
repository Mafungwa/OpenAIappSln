using OpenAIapp.Views;

namespace OpenAIapp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("displayview", typeof(DisplayView));
            //Routing.RegisterRoute("loadsheddinganswer", typeof(LoadsheddingAnswerPage));
        }

    }
}
