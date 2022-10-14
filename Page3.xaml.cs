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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
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
            char[] alfavit = {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О',
                'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б',
                'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
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
                if (p != 66)
                {
                    n = p; //индекс буквы
                    d = n + key; //делаем смещение по ключу 
                    //Если вышли за пределы алфавита
                    if (d > 65)
                    {
                        d = d - 66;
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
            char[] alfavit = {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О',
                'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б',
                'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
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
                if (p != 66)
                {
                    n = p; //индекс буквы
                    d = n - key; //делаем смещение по ключу 
                    //Если вышли за пределы алфавита
                    if (d < 0)
                    {
                        d = d + 66;
                    }
                    text[l] = alfavit[d]; //меняем букву
                }
            }
            pa = new string(text); //собираем в одну строку
            Serv.Text = pa; // выводи на консоль; // выводи на консоль
        }
    }
}

