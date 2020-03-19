using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A3DCardDialer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TbMainPage : TabbedPage
    {
        public TbMainPage()
        {
            InitializeComponent();
            this.Title = "A3D Card Dialer";
            this.IconImageSource = ImageSource.FromResource("A3D.ico");
            
        }
    }
}