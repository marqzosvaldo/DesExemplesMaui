using DesExemples.ViewModels;

namespace DesExemples.Views;

public partial class MasterHomePage : ContentPage {
	public MasterHomePage(MasterHomeViewModel vm) {
		InitializeComponent();
		BindingContext = vm;
	}
}