using Breakwater.ApplicationState;
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

namespace Breakwater.UI
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class ArmBerm : Page
    {
        private ApplicationState.ApplicationState.ArmBermPage _thisPage;

        public ArmBerm()
        {
            InitializeComponent();
            _thisPage = StateManagers.ArmBermState.GetState();
            this.DataContext = _thisPage;

            InitComponentStates();
        }

        private void InitComponentStates()
        {
            ArmStcMainHTxtbx.Text = _thisPage.ArmStcMainHTxtbxValue;
            ArmStcMainTmTxtbx.Text = _thisPage.ArmStcMainCotTxtbxValue;
            ArmStcMainRhoSTxtbx.Text = _thisPage.ArmStcMainRhoSTxtbxValue;
            ArmStcMainRhoWTxtbx.Text = _thisPage.ArmStcMainRhoWTxtbxValue;
            ArmStcMainCotTxtbx.Text = _thisPage.ArmStcMainCotTxtbxValue;
            ArmStcMainKDTxtbx.Text = _thisPage.ArmStcMainKDTxtbxValue;
            ArmStcMainSTxtbx.Text = _thisPage.ArmStcMainSTxtbxValue;
            ArmStcMainPTxtbx.Text = _thisPage.ArmStcMainPTxtbxValue;
            ArmStcMainNWTxtbx.Text = _thisPage.ArmStcMainNWTxtbxValue;
            ArmStcMainDeltaTxtbx.Text = _thisPage.ArmStcMainDeltaTxtbxValue;
            ArmStcMainHudNSTxtbx.Text = _thisPage.ArmStcMainHudNSTxtbxValue;
            ArmStcMainVDMNSTxtbx.Text = _thisPage.ArmStcMainVDMNSTxtbxValue;
            ArmStcMainESBNSTxtbx.Text = _thisPage.ArmStcMainESBNSTxtbxValue;
            ArmStcMainHudDN50Txtbx.Text = _thisPage.ArmStcMainHudDN50TxtbxValue;
            ArmStcMainVDMDN50Txtbx.Text = _thisPage.ArmStcMainVDMDN50TxtbxValue;
            ArmStcMainESBDN50Txtbx.Text = _thisPage.ArmStcMainESBDN50TxtbxValue;
            ArmStcMainHudM50Txtbx.Text = _thisPage.ArmStcMainHudM50TxtbxValue;
            ArmStcMainVDMM50Txtbx.Text = _thisPage.ArmStcMainVDMM50TxtbxValue;
            ArmStcMainESBM50Txtbx.Text = _thisPage.ArmStcMainESBM50TxtbxValue;
            ArmStcMainUserM0Txtbx.Text = _thisPage.ArmStcMainUserM0TxtbxValue;
            ArmStcMainUserM100Txtbx.Text = _thisPage.ArmStcMainUserM100TxtbxValue;
            ArmStcMainUserDN50Txtbx.Text = _thisPage.ArmStcMainUserDN50TxtbxValue;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    textbox1.Text = _thisPage.TextboxValue;
        //}

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            _thisPage.ArmStcMainHTxtbxValue = ArmStcMainHTxtbx.Text;
            _thisPage.ArmStcMainTmTxtbxValue = ArmStcMainTmTxtbx.Text;
            _thisPage.ArmStcMainRhoSTxtbxValue = ArmStcMainRhoSTxtbx.Text;
            _thisPage.ArmStcMainRhoWTxtbxValue = ArmStcMainRhoWTxtbx.Text;
            _thisPage.ArmStcMainCotTxtbxValue = ArmStcMainCotTxtbx.Text;
            _thisPage.ArmStcMainKDTxtbxValue = ArmStcMainKDTxtbx.Text;
            _thisPage.ArmStcMainSTxtbxValue = ArmStcMainSTxtbx.Text;
            _thisPage.ArmStcMainPTxtbxValue = ArmStcMainPTxtbx.Text;
            _thisPage.ArmStcMainNWTxtbxValue = ArmStcMainNWTxtbx.Text;
            _thisPage.ArmStcMainDeltaTxtbxValue = ArmStcMainDeltaTxtbx.Text;
            _thisPage.ArmStcMainHudNSTxtbxValue = ArmStcMainHudNSTxtbx.Text;
            _thisPage.ArmStcMainVDMNSTxtbxValue = ArmStcMainVDMNSTxtbx.Text;
            _thisPage.ArmStcMainESBNSTxtbxValue = ArmStcMainESBNSTxtbx.Text;
            _thisPage.ArmStcMainHudDN50TxtbxValue = ArmStcMainHudDN50Txtbx.Text;
            _thisPage.ArmStcMainVDMDN50TxtbxValue = ArmStcMainVDMDN50Txtbx.Text;
            _thisPage.ArmStcMainESBDN50TxtbxValue = ArmStcMainESBDN50Txtbx.Text;
            _thisPage.ArmStcMainHudM50TxtbxValue = ArmStcMainHudM50Txtbx.Text;
            _thisPage.ArmStcMainVDMM50TxtbxValue = ArmStcMainVDMM50Txtbx.Text;
            _thisPage.ArmStcMainESBM50TxtbxValue = ArmStcMainESBM50Txtbx.Text;
            _thisPage.ArmStcMainUserM0TxtbxValue = ArmStcMainUserM0Txtbx.Text;
            _thisPage.ArmStcMainUserM100TxtbxValue = ArmStcMainUserM100Txtbx.Text;
            _thisPage.ArmStcMainUserDN50TxtbxValue = ArmStcMainUserDN50Txtbx.Text;
        }
    }
}
