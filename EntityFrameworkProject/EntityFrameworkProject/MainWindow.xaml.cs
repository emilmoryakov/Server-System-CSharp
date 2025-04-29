using EntityFrameworkProject.DbContexts;
using EntityFrameworkProject.DbModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace EntityFrameworkProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CountryDbContext CountryContext;
        public ObservableCollection<Country> Countries { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            CountryContext = new CountryDbContext();
            Countries = new ObservableCollection<Country>();
            LoadCountries();
        }

        private void LoadCountries()
        {
            var countries = CountryContext.Countries.ToList();

            foreach (var country in countries)
            {
                Countries.Add(country);
            }

            CountriesDataGrid.ItemsSource = Countries;

        }

        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedSortOption = SortComboBox.SelectedItem.ToString();

            switch (selectedSortOption)
            {
                case "Sort by Name":
                    ReturnCountriesSortedByName();
                    break;
                case "Sort by Population":
                    ReturnCountriesSortedByPopulation();
                    break;
                case "Sort by GDP":
                    ReturnCountriesSortedByGDP();
                    break;
                default:
                    break;
            }
        }

        private void ReturnCountriesSortedByGDP()
        {
            if (Countries != null)
            {
                var sortedCountries = Countries.OrderBy(c => c.GDP).ToList();
                Countries.Clear();
                foreach (var country in sortedCountries)
                {
                    Countries.Add(country);
                }
            }
        }

        private void ReturnCountriesSortedByPopulation()
        {
            if (Countries != null)
            {
                var sortedCountries = Countries.OrderBy(c => c.Population).ToList();
                Countries.Clear();
                foreach (var country in sortedCountries)
                {
                    Countries.Add(country);
                }
            }
        }

        private void ReturnCountriesSortedByName()
        {
            if (Countries != null)
            {
                var sortedCountries = Countries.OrderBy(c => c.Name).ToList();
                Countries.Clear();
                foreach (var country in sortedCountries)
                {
                    Countries.Add(country);
                }
            }
        }
    }
}
