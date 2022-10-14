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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Зашифровать_Click(object sender, RoutedEventArgs e)
        {
            string m = Text.Text;
            string k = Key.Text;
            char[] mas = m.ToCharArray();
            int key = Convert.ToInt32(k);
            string en; //результат

            int p; //переменная в цикле
            int n; //номер в алфавите
            int d; //смещение
            char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //перебираем каждый символ сообщения
            for (int i = 0; i < mas.Length; i++)
            {
                for (p = 0; p < alfavit.Length; p++)//поиск индекса буквы
                {
                    if (mas[i] == alfavit[p])
                    {
                        break;
                    }
                }
                if (p != 52)
                {
                    n = p; //индекс буквы
                    d = n + key; //делаем смещение по ключу 
                    //Если вышли за пределы алфавита
                    if (d > 51)
                    {
                        d = d - 52;
                    }
                    mas[i] = alfavit[d]; //меняем букву
                }
            }
            en = new string(mas); //собираем в одну строку
            Serv.Text = en; // выводи на консоль
        }

        private void Расшифровать_Click(object sender, RoutedEventArgs e)
        {
            string m = Serv.Text;
            string k = Key.Text;
            char[] text = m.ToCharArray();
            int key = Convert.ToInt32(k);
            string pa; //результат
            int p; //переменная в цикле

            int n; //номер в алфавите
            int d; //смещение
            char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //перебираем каждый символ сообщения
            for (int l = 0; l < text.Length; l++)
            {
                for (p = 0; p < alfavit.Length; p++)//поиск индекса буквы
                {
                    if (text[l] == alfavit[p])
                    {
                        break;
                    }
                }
                if (p != 52)
                {
                    n = p; //индекс буквы
                    d = n - key; //делаем смещение по ключу 
                    //Если вышли за пределы алфавита
                    if (d < 0)
                    {
                        d = d + 51;
                    }
                    text[l] = alfavit[d]; //меняем букву
                }
            }
            pa = new string(text); //собираем в одну строку
            Serv.Text = pa; // выводи на консоль; // выводи на консоль
        }

       
    }
    
}
