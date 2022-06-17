using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using tarea3.Models;
using tarea3.Controller;

namespace tarea3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

     
        private async void btnsalvar_Clicked(object sender, EventArgs e)
        {
            var personass = new personas
          
            {
                id = 0,
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                edad = Int32.Parse(txtedad.Text),//convertimos nuestro tipo int a String
                correo = txtemail.Text,
                direccion = txtdireccion.Text

                

            };
           
            //si no esta la informacion la guardamos
           var result = await App.dbpersona.personaSave(personass);
            if(result > 0)
            {
                await DisplayAlert("Persona Guardada", "Aviso", "Ok");
            }
            else
            {
                await DisplayAlert("Ha ocurrido un error", "Aviso", "Ok");
            }
           
        }

        private async void btneliminar_Clicked(object sender, EventArgs e)
        {
            var personass = new personas

            {
                id = Convert.ToInt32(txtid.Text),
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                edad = Int32.Parse(txtedad.Text),//convertimos nuestro tipo int a String
                correo = txtemail.Text,
                direccion = txtdireccion.Text
                



            };
            var result = await App.dbpersona.eliminarpersonas(personass);
            await DisplayAlert("Aviso", "Persona eliminada","Ok");
        }

        private async void btnactualizar_Clicked(object sender, EventArgs e)
        {
            var personass = new personas

            {
                id = Convert.ToInt32(txtid.Text),
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                edad = Int32.Parse(txtedad.Text),//convertimos nuestro tipo int a String
                correo = txtemail.Text,
                direccion = txtdireccion.Text



            };
            var result = await App.dbpersona.personaSave(personass);
            await DisplayAlert("Aviso", "Persona Actualizada", "Ok");

        }
    }
}
