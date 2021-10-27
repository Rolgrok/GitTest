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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Entities entities = new Entities();
        public Window1()
        {
            InitializeComponent();
            foreach (var genre in entities.Genre)
                GenreList.Items.Add(genre);
        }

        private void FilmsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected_genre = GenreList.SelectedItem as Genre;
            if (selected_genre != null)
            {
                textBoxNameGenre.Text = selected_genre.Genre1;
            }
            else
            {
                textBoxNameGenre.Text = "";
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            var genre = GenreList.SelectedItem as Genre;
            if (textBoxNameGenre.Text == "")
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите добавить новую запись?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    if (genre == null)
                    {
                        genre = new Genre();
                        entities.Genre.Add(genre); // 10: entities.AddToTovari(add_tovar);
                        GenreList.Items.Add(genre);
                    }
                    genre.Genre1 = textBoxNameGenre.Text;
                    entities.SaveChanges();
                    GenreList.Items.Refresh();
                }
                else
                {
                    textBoxNameGenre.Text = "";
                    GenreList.SelectedIndex = -1;
                    textBoxNameGenre.Focus();
                }
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            var delete_genre = GenreList.SelectedItem as Genre;
            if (delete_genre != null)
            {
                try
                {
                    var exist = (from Films in entities.Films where Films.GenreID == delete_genre.Id select Films).First();
                    MessageBox.Show("Запись удалить нельзя!\nСуществуют фильмы данного жанра", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch
                {
                    MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Error);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        entities.Genre.Remove(delete_genre);
                        entities.SaveChanges();
                        textBoxNameGenre.Clear();
                        GenreList.Items.Remove(delete_genre);
                    }
                }
            }
            else
                MessageBox.Show("Нет удаляемых объектов!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            textBoxNameGenre.Text = "";
            GenreList.SelectedIndex = -1;
            textBoxNameGenre.Focus();
        }
    }
}
