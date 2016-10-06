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
using MimAcher.Entidades;


namespace MimAcher
{
    [Activity(Label = "InscreverActivity", Theme = "@style/Theme.Splash")]
    public class InscreverActivity : Activity
    {
        public Bundle participante_bundle;

        //Initializing variables from layout
        string usuario = null;
        string senha = null;
        string nome = "Fulano";
        string email = null;
        string nascimento = null;
        string telefone = null;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            participante_bundle = Intent.GetBundleExtra("member");
            Participante participante = Participante.BundleToParticipante(participante_bundle);

            // Create your application here
            SetContentView(Resource.Layout.Inscrever);

            
            Button botao_avan�ar = FindViewById<Button>(Resource.Id.avan�ar);
            EditText campo_usuario = FindViewById<EditText>(Resource.Id.usuario);
            EditText campo_senha = FindViewById<EditText>(Resource.Id.senha);
            EditText campo_nome = FindViewById<EditText>(Resource.Id.nome);
            EditText campo_e_mail = FindViewById<EditText>(Resource.Id.email);
            EditText campo_dt_nascimento = FindViewById<EditText>(Resource.Id.dt_nascimento);
            EditText campo_telefone = FindViewById<EditText>(Resource.Id.telefone);
            
            //Pegar as informa��es inseridas
            campo_usuario.TextChanged += (object sender, Android.Text.TextChangedEventArgs u) => {
                usuario = u.Text.ToString();
            };

            campo_senha.TextChanged += (object sender, Android.Text.TextChangedEventArgs s) => {
                senha = s.Text.ToString();
            };

            campo_nome.TextChanged += (object sender, Android.Text.TextChangedEventArgs n) => {
                nome = n.Text.ToString();
            };

            campo_e_mail.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                email = e.Text.ToString();
            };

            campo_dt_nascimento.TextChanged += (object sender, Android.Text.TextChangedEventArgs n) => {
                nascimento = n.Text.ToString();
            };

            campo_telefone.TextChanged += (object sender, Android.Text.TextChangedEventArgs t) => {
                telefone = t.Text.ToString();
            };
            //TODO Pegar informa��es de data fim curso e do tipo de usu�rio e campus
            
            
            botao_avan�ar.Click += delegate {
                participante = CriarParticipante();
                participante.Commit();

                var escolherfotoactivity = new Intent(this, typeof(EscolherFotoActivity));
                escolherfotoactivity.PutExtra("member", participante.ParticipanteToBundle());
                StartActivity(escolherfotoactivity);
            };

        }

        
         
        private Participante CriarParticipante()
        {
            Dictionary<string, string> informacoes = new Dictionary<string, string>();
            informacoes["id"] = usuario;
            informacoes["senha"] = senha;
            informacoes["email"] = email;
            informacoes["nome"] = nome;
            informacoes["telefone"] = telefone;
            informacoes["nascimento"] = nascimento;

            Participante participante = new Participante(informacoes);

            return participante;
        }
    }
}

