using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MimAcher.Entidades
{
    public class Nac : Usuario
    {
        

        public Nac(Dictionary<string, string> atributos) : base(atributos)
        {
            this.NomeRepresentante = atributos["nomeRepresentante"];
            this.Campus = atributos["campus"];
            this.Telefone = atributos["telefone"];
        }

        private string NomeRepresentante { get; set; }
        private string Campus { get; set; }
        public string Telefone { get; set; }
    }
}