using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf005_MVVM.Model;
using wpf005_MVVM.ViewModel.Helpers;
using wpf005_MVVM.ViewModel.Commands;
using System.Collections.ObjectModel;

namespace wpf005_MVVM.ViewModel
{
    public class WeatherVM : INotifyPropertyChanged
    {
        private string query;

        public string Query
        {
            get { return query; }
            set
            {
                query = value;
                OnPropertyChanged("Query");
            }
        }

        public ObservableCollection<City> Cities { get; set; }

        private CurrentConditions currentCondic;

        public CurrentConditions CurrentCondic
        {
            get { return currentCondic; }
            set
            {
                currentCondic = value;
                OnPropertyChanged("CurrentCondic");
            }
        }

        private City _selecteCity;

        public City SelectedCity
        {
            get { return _selecteCity; }
            set
            {
                _selecteCity = value;
                OnPropertyChanged("SelectedCity");
                GetCurrentConditions();
            }
        }

        public SearchCommand Search { get; set; }

        public WeatherVM()
        {
            //if(DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            //{
            //    SelectedCity = new City
            //    {
            //        LocalizedName = "New York"
            //    };
            //    CurrentCondic = new CurrentConditions
            //    {
            //        WeatherText = "Party cloudy",
            //        Temperature = new Temperature
            //        {
            //            Metric = new Metric
            //            {
            //                Value = "21"
            //            }
            //        }
            //    };
            //}

            Search = new SearchCommand(this);

            Cities = new ObservableCollection<City>();

            

        }

        private async void GetCurrentConditions()
        {
            Query = string.Empty;
            Cities.Clear();
            CurrentCondic = await 
                AccuWeatherHelper.GetCurrentConditions(SelectedCity.Key);
        }

        public async void MakeQuery()
        {
            var cities = await AccuWeatherHelper.GetCities(Query);

            Cities.Clear();

            foreach (var city in cities)
            {
                Cities.Add(city);
            }

        }

        
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
