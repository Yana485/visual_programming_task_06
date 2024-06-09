using System;
using System.Collections.Generic;
using System.Windows;

namespace task6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            List<User> users = new List<User>
            {
                new User { Id = 1, Name = "Тарас Шевченко", Birthday = new DateTime(1984, 3, 9), ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/%D0%A2._%D0%93._%D0%A8%D0%B5%D0%B2%D1%87%D0%B5%D0%BD%D0%BA%D0%BE._%D0%9A%D0%B2%D1%96%D1%82%D0%B5%D0%BD%D1%8C_1859.jpg/800px-%D0%A2._%D0%93._%D0%A8%D0%B5%D0%B2%D1%87%D0%B5%D0%BD%D0%BA%D0%BE._%D0%9A%D0%B2%D1%96%D1%82%D0%B5%D0%BD%D1%8C_1859.jpg" },
                new User { Id = 2, Name = "Леся Українка", Birthday = new DateTime(1871, 2, 25), ImageUrl = "https://static.ukrinform.com/photos/2021_02/thumb_files/630_360_1613729387-345.jpg" },
                new User { Id = 3, Name = "Василь Стус", Birthday = new DateTime(1938, 1, 6), ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/db/EthnoCarpathians_22082017DolynaUA-26_Crop_and_fix.jpg" }
            };

            dgUsers.ItemsSource = users;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string ImageUrl { get; set; }
    }
}
