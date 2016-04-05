using MVVMDemo.Views;

namespace MVVMDemo.ViewModels
{
    public class ViewAViewModel:IViewAViewModel
    {
        public IView View { get; set; }

        public ViewAViewModel(IViewA view)
        {
            View = view;
            View.ViewModel = this;
        }

        public string FirstName { get; set; } = "Babar QB";
    }
}