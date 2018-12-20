using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RefactorizacionMobil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnButtonAddClicked(object sender, EventArgs args)
        {
            Operaciones OP = new Operaciones();
            var Value1 =int.Parse( EntryValue1.Text);
            var Value2 = int.Parse(EntryValue2.Text);
            try
            {
                LabelResult.Text = OP.Add(Value1, Value2).ToString();
            }
            catch (DivideByZeroException ex)
            {

                DisplayAlert("Divided By Zero", ex.Message, "Ok");
            }
            catch(FileNotFoundException)
            {

            }
           

        }
    }
}
