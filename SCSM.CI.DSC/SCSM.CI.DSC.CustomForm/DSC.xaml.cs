using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SCSM.CI.DSC.CustomForm
{
    /// <summary>
    /// Interaction logic for DSC.xaml
    /// </summary>
    public partial class DSC : UserControl
    {
        public DSC()
        {
            InitializeComponent();
            _relatedItemsPane = new RelatedItemsPane(new ConfigItemRelatedItemsConfiguration());
            tabItemRelItems.Content = _relatedItemsPane;
        }
    }
}
