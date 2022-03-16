using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Identificando qual botão disparou o evento
            Button btn = (Button)sender;

            // Desabilitando o botão
            btn.IsEnabled = false;

            // Trocando texto do botão de acordo com quem é a vez.
            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            // verificando se a primeira linha teve ganhador
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
            }

            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
            }

            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
            }

            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
            }

            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
            }

            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            else if (btn1.IsEnabled == false && btn2.IsEnabled == false && btn3.IsEnabled == false && btn4.IsEnabled == false && btn5.IsEnabled == false && btn6.IsEnabled == false && btn7.IsEnabled == false && btn8.IsEnabled == false && btn9.IsEnabled == false)
            {
                await DisplayAlert("Velha!", "Os jogadores 'X' e 'O' perderam", "Ok");
                zerar();
            }




        }


        void zerar()
        {
            btn1.IsEnabled = true;
            btn1.Text = "";
            btn2.IsEnabled = true;
            btn2.Text = "";
            btn3.IsEnabled = true;
            btn3.Text = "";
            btn4.IsEnabled = true;
            btn4.Text = "";
            btn5.IsEnabled = true;
            btn5.Text = "";
            btn6.IsEnabled = true;
            btn6.Text = "";
            btn7.IsEnabled = true;
            btn7.Text = "";
            btn8.IsEnabled = true;
            btn8.Text = "";
            btn9.IsEnabled = true;
            btn9.Text = "";

        }
    }
}
