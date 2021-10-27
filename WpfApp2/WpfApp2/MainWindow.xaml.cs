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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Entities entities = new Entities();
        public MainWindow()
        {
            InitializeComponent();
            foreach (var films in entities.Films)
                FilmsList.Items.Add(films);
            foreach (var genre in entities.Genre)
                comboBox_GenreFilms.Items.Add(genre);

        }

        private void FilmsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected_films = FilmsList.SelectedItem as Films;
            if (selected_films != null)
            {
                textBoxName.Text = selected_films.Title;
                textBoxDirect.Text = selected_films.DirectedBy;
                textBoxYear.Text = selected_films.YearOfProduction;
                textBoxCountry.Text = selected_films.Country;
                comboBox_GenreFilms.SelectedItem = (from vid in entities.Genre where vid.Id == selected_films.GenreID select vid).Single<Genre>();
            }
            else
            {
                textBoxName.Text = "";
                comboBox_GenreFilms.SelectedIndex = -1;
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            var delete_films = FilmsList.SelectedItem as Films;
            if (delete_films != null)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Error);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    entities.Films.Remove(delete_films);
                    entities.SaveChanges();
                    textBoxName.Clear();
                    textBoxCountry.Clear();
                    textBoxDirect.Clear();
                    textBoxYear.Clear();
                    FilmsList.Items.Remove(delete_films);
                    comboBox_GenreFilms.SelectedIndex = -1;
                }
            }
            else
                MessageBox.Show("Нет удаляемых объектов!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            var films = FilmsList.SelectedItem as Films;
            if (textBoxName.Text == "" || comboBox_GenreFilms.SelectedIndex == -1 || textBoxYear.Text == "" || textBoxDirect.Text == "" || textBoxCountry.Text == "")
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите добавить новую запись?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    if (films == null)
                    {
                        films = new Films();
                        entities.Films.Add(films);
                        FilmsList.Items.Add(films);
                    }
                    films.Title = textBoxName.Text;
                    films.GenreID = (comboBox_GenreFilms.SelectedItem as Genre).Id;
                    films.DirectedBy = textBoxDirect.Text;
                    films.Country = textBoxCountry.Text;
                    films.YearOfProduction = textBoxYear.Text;
                    entities.SaveChanges();
                    FilmsList.Items.Refresh();
                }
                else
                {
                    textBoxName.Text = "";
                    textBoxYear.Text = " ";
                    textBoxDirect.Text = "";
                    textBoxCountry.Text = "";
                    FilmsList.SelectedIndex = -1;
                    comboBox_GenreFilms.SelectedIndex = -1;
                    textBoxName.Focus();
                }

            }

        }

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text = "";
            textBoxYear.Text = " ";
            textBoxDirect.Text = "";
            textBoxCountry.Text = "";
            FilmsList.SelectedIndex = -1;
            comboBox_GenreFilms.SelectedIndex = -1;
            textBoxName.Focus();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            comboBox_GenreFilms.Items.Clear();
            FilmsList.Items.Clear();
            foreach (var genre in entities.Genre)
                comboBox_GenreFilms.Items.Add(genre);
            foreach (var films in entities.Films)
                FilmsList.Items.Add(films);
        }
    }
}

