using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<string> estudiantes = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                estudiantes.Add("Estudiante " + i.ToString());
            }
            //lvEstudiantes.ItemsSource = estudiantes;



            List<Estudiante> estudiantes1= new List<Estudiante>();
            for (int i = 0; i < 10; i++)
            {
                estudiantes1.Add(
                    new Estudiante
                    {
                        Nombres = "Nombres " + i.ToString(),
                        Apellidos = "Apellidos " + i.ToString(),
                        Edad = i
                    }
                    ); ;
            }

            lvEstudiantes1.ItemsSource = estudiantes1;


        }
    }
}
