using Nest;
using Newtonsoft.Json;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestAPP.Models;

namespace TestAPP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient client = new HttpClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var user = new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordBox.Password
            };

            string apiUrl = "https://localhost:44338/api/"; // Замените на ваш URL
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(apiUrl, content);
                HandleResponse(response);

            }
            catch (Exception ex)
            {
                DisplayErrorMessage("Произошла ошибка: " + ex.Message);
            }

        }

        private void HandleResponse(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                DisplaySuccessMessage("Авторизация успешна!");
                // Здесь вы можете перейти на другую страницу или выполнить другую логику
            }
            else
            {
                DisplayErrorMessage("Ошибка авторизации: " + response.ReasonPhrase);
            }
        }

        private void DisplaySuccessMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

    }
}

