using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesExemples.ViewModels {
    public partial class MasterHomeViewModel: ObservableObject{
        [ObservableProperty]
        int _positionSelected = 0;

        public MasterHomeViewModel(){
                
        }
    }
}
