using AutoCustomsClearance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoCustomsClearance.XAML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatorPage : ContentPage
	{
        public Picker YearPicker { get; set; }
        public CalculatorPage ()
		{
			InitializeComponent ();
            // create a year picker
            YearPicker = new Picker
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 15
            };
            // set year of auto by picker
            YearPicker.Items.Add("до 3-х лет");
            YearPicker.Items.Add("от 3-х до 5-ти лет");
            YearPicker.Items.Add("старше 5-ти лет");
            YearPicker.SelectedIndex = 1;
            YearOfAuto.Content = YearPicker;
		}
        /// <summary>
        /// Gasoline engine for business
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="cost"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        private double GasolineEngineForBusinessPaymentCalculate(double volume, double cost)
        {
            double payment = 0;
            if (YearPicker.SelectedIndex == 0)
            {
                if (volume <= 1000)
                    payment = (0.3 * cost) > (1.2 * volume) ? (0.3 * cost) : (1.2 * volume);
                if (volume > 1000 && volume <= 1500)
                    payment = (0.3 * cost) > (1.45 * volume) ? (0.3 * cost) : (1.45 * volume);
                if (volume > 1500 && volume <= 1800)
                    payment = (0.3 * cost) > (1.5 * volume) ? (0.3 * cost) : (1.5 * volume);
                if (volume > 1800 && volume <= 3000)
                    payment = (0.3 * cost) > (2.15 * volume) ? (0.3 * cost) : (2.15 * volume);
                if (volume > 3000)
                    payment = (0.3 * cost) > (2.8 * volume) ? (0.3 * cost) : (2.8 * volume);
            }
            if (YearPicker.SelectedIndex == 1)
            {
                if (volume <= 1000)
                    payment = (0.35 * cost) > (1.2 * volume) ? (0.35 * cost) : (1.2 * volume);
                if (volume > 1000 && volume <= 1500)
                    payment = (0.35 * cost) > (1.45 * volume) ? (0.35 * cost) : (1.45 * volume);
                if (volume > 1500 && volume <= 1800)
                    payment = (0.35 * cost) > (1.5 * volume) ? (0.35 * cost) : (1.5 * volume);
                if (volume > 1800 && volume <= 3000)
                    payment = (0.35 * cost) > (2.15 * volume) ? (0.35 * cost) : (2.15 * volume);
                if (volume > 3000)
                    payment = (0.35* cost) > (2.8 * volume) ? (0.35 * cost) : (2.8 * volume);
            }
            if (YearPicker.SelectedIndex == 2)
            {
                if (volume <= 1000)
                    payment = 2.5 * volume;
                if (volume > 1000 && volume <= 1500)
                    payment = 2.7 * volume;
                if (volume > 1500 && volume <= 1800)
                    payment = 2.9 * volume;
                if (volume > 1800 && volume <= 3000)
                    payment = 4 * volume;
                if (volume > 3000)
                    payment = 5.8 * volume;
            }
            return payment;
        }
        /// <summary>
        /// Diesel engine for business
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="cost"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        private double DieselEngineForBusinessPaymentCalculate(double volume, double cost)
        {
            double payment = 0;
            if (YearPicker.SelectedIndex == 0)
            {
                if (volume <= 1500)
                    payment = (0.3 * cost) > (1.45 * volume) ? (0.3 * cost) : (1.45 * volume);
                if (volume > 1500 && volume <= 2500)
                    payment = (0.3 * cost) > (2.15 * volume) ? (0.3 * cost) : (2.15 * volume);
                if (volume > 2500)
                    payment = (0.3 * cost) > (2.8 * volume) ? (0.3 * cost) : (2.8 * volume);
            }
            if (YearPicker.SelectedIndex == 1)
            {
                if (volume <= 1500)
                    payment = (0.35 * cost) > (1.45 * volume) ? (0.35 * cost) : (1.45 * volume);
                if (volume > 1500 && volume <= 2500)
                    payment = (0.35 * cost) > (2.15 * volume) ? (0.35 * cost) : (2.15 * volume);
                if (volume > 2500)
                    payment = (0.35 * cost) > (2.8 * volume) ? (0.35 * cost) : (2.8 * volume);
            }
            if (YearPicker.SelectedIndex == 2)
            {
                if (volume <= 1500)
                    payment = 2.7 * volume;
                if (volume > 1500 && volume <= 2500)
                    payment = 4 * volume;
                if (volume > 2500)
                    payment = 5.8 * volume;
            }
            return payment;
        }
        /// <summary>
        /// Payment for private using
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="cost"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        private double ForPrivatePersonPaymentCalculate(double volume, double cost)
        {
            double payment = 0;
            if (YearPicker.SelectedIndex == 0)
            {
                if (cost <= 8500)
                    payment = (0.54 * cost) > (2.5 * volume) ? (0.54 * cost) : (2.5 * volume);
                if (cost > 8500 && cost <= 16700)
                    payment = (0.48 * cost) > (3.5 * volume) ? (0.48 * cost) : (3.5 * volume);
                if (cost > 16700 && cost <= 42300)
                    payment = (0.48 * cost) > (5.5 * volume) ? (0.48 * cost) : (5.5 * volume);
                if (cost > 42300 && cost <= 84500)
                    payment = (0.48 * cost) > (7.5 * volume) ? (0.48 * cost) : (7.5 * volume);
                if (cost > 84500 && cost <= 169000)
                    payment = (0.48 * cost) > (15 * volume) ? (0.48 * cost) : (15 * volume);
                if (cost > 169000)
                    payment = (0.48 * cost) > (20 * volume) ? (0.48 * cost) : (20 * volume);
            }
            if (YearPicker.SelectedIndex == 1)
            {
                if (volume <= 1000)
                    payment = 1.5 * volume;
                if (volume > 1000 && volume <= 1500)
                    payment = 1.7 * volume;
                if (volume > 1500 && volume <= 1800)
                    payment = 2.5 * volume;
                if (volume > 1800 && volume <= 2300)
                    payment = 2.7 * volume;
                if (volume > 2300 && volume <= 3000)
                    payment = 3 * volume;
                if (volume > 3000)
                    payment = 3.6 * volume;
            }
            if (YearPicker.SelectedIndex == 2)
            {
                if (volume <= 1000)
                    payment = 3 * volume;
                if (volume > 1000 && volume <= 1500)
                    payment = 3.2 * volume;
                if (volume > 1500 && volume <= 1800)
                    payment = 3.5 * volume;
                if (volume > 1800 && volume <= 2300)
                    payment = 4.8 * volume;
                if (volume > 2300 && volume <= 3000)
                    payment = 5 * volume;
                if (volume > 3000)
                    payment = 5.7 * volume;
            }
            return payment;
        }
        /// <summary>
        /// to calculate payment for electric car
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        private double ElectricEnginePaymentCalculate(double cost)
        {
            if (cost <= 8500)
                return 0.54 * cost;
            else
                return 0.48 * cost;
        }
        /// <summary>
        /// when this swith is toggled, value of volume entry sets to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElectricCarToggled(object sender, ToggledEventArgs e)
        {
            if (!isElectricEngine.IsToggled)
                Volume.Text = null;
            else
                Volume.Text = "0";
        }
        /// <summary>
        /// to calculate payments for Customs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCalculateClicked(object sender, EventArgs e)
        {
            // check input
            string entryNumPattern = @"\d*";
            if (String.IsNullOrEmpty(Cost.Text) || String.IsNullOrEmpty(Volume.Text))
            {
                Results.Children.Clear();
                DependencyService.Get<IToastMessage>().ShowMesssage("Заполните, пожалуйста, все поля");
            }             
            else if (!Regex.IsMatch(Cost.Text,entryNumPattern)||!Regex.IsMatch(Volume.Text, entryNumPattern))
            {
                Results.Children.Clear();
                DependencyService.Get<IToastMessage>().ShowMesssage("Заполните, пожалуйста, все поля");
            }
            else
            {
                double result = 0;
                Results.Children.Clear();
                double cost = Double.Parse(Cost.Text);
                double volume = Double.Parse(Volume.Text);
                // if this auto is electric car
                if (isElectricEngine.IsToggled)
                {
                    result = ElectricEnginePaymentCalculate(cost);
                }
                // if this auto for business
                else if (isBuisnes.IsToggled)
                {
                    isDiscount.IsToggled = false;
                    if (EngineType.SelectedIndex==0)
                    {
                        result = GasolineEngineForBusinessPaymentCalculate(volume, cost);
                    }
                    else
                    {
                        result = DieselEngineForBusinessPaymentCalculate(volume, cost);
                    }
                }
                // if this auto only for private person
                else
                {
                    result = ForPrivatePersonPaymentCalculate(volume, cost);
                    if (isDiscount.IsToggled)
                        result = result / 2;
                }
                resultFrame.IsVisible = true;
                Results.Children.Add(new Label
                {
                    Text = "Размер пошлины: " + result.ToString("0.00") + " EUR",
                    FontSize = 18,
                    FontAttributes = FontAttributes.Bold,
                    Margin = 15
                });
                

            }
        }
        /// <summary>
        /// info about discount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHelpClicked(object sender, EventArgs e)
        {
            DisplayAlert("Справка","Согласно указу Президента РБ №140 от 10.04.2019 " +
                "инвалидам I и II групп, а также родителям (усыновителям) в многодетных семьях " +
                "возмещается 50% таможенных пошлин. Возмещение производится однократно в течение года", "Понятно");
        }      
        /// <summary>
        /// info about electric cars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHelpByEletricCarClicked(object sender, EventArgs e)
        {
            DisplayAlert("Справка","Под электромобилем понимается автомобиль, приводимый в действие ТОЛЬКО" +
                " электродвигателем, гибриды в эту категорию не входят." +
                " В целях стимулирования использования электромобилей в РБ, согласно Указу Президента РБ №273 от 10.07.2018 электромобили освобождаются от уплаты дорожного налога" +
                " вплоть до 31.12.2020 года. ","ОК");
        }
        /// <summary>
        /// reset data in enrtys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnResetClicked(object sender, EventArgs e)
        {
            resultFrame.IsVisible = false;
            YearPicker.SelectedIndex = 1;
            isDiscount.IsToggled = false;
            isBuisnes.IsToggled = false;
            isElectricEngine.IsToggled = false;
            Cost.Text = null;
            Volume.Text = null;
            Results.Children.Clear();
        }
    }
}