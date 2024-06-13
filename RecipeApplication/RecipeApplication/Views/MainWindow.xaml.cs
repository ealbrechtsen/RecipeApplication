using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RecipeApplication.Views;
using RecipeApplication.ViewModel;
using RecipeApplication.Model;

namespace RecipeApplication.Views
{

    public partial class MainWindow : Window
    {
        MainViewModel mvm;
        CreateRecipeDialog createRecipeDialog;
        CreateRecipeDialogVM createRecipeDialogVM;

        public MainWindow()
        {
            InitializeComponent();
            mvm = new MainViewModel(createRecipeDialogVM);
            DataContext = mvm;
        }
    }
}