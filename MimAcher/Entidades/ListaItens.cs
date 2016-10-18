using System.Collections.Generic;
using Android.Content;
using Android.Widget;

namespace MimAcher.Mobile.Entidades
{
    public class ListaItens
    {
        public List<string> Itens { get; set; }

        public ListaItens()
        {
            Itens = new List<string>();
        }

        //adicionar itens
        public void AdicionarItemWithMessage(string item, Context activity, string text)
        {
            if (!string.IsNullOrEmpty(item))
            {
                if (!Itens.Contains(item))
                {
                    Itens.Add(item);
                    var toast = string.Format("{1} Inserido: {0}", item, text);
                    Toast.MakeText(activity, toast, ToastLength.Long).Show();
                }
                else
                {
                    var toast = string.Format("Voce j� possui este {1}: {0} ", item, text);
                    Toast.MakeText(activity, toast, ToastLength.Long).Show();
                }
            }
            else
            {
                const string toast = ("Nada Inserido");
                Toast.MakeText(activity, toast, ToastLength.Long).Show();
            }
        }

        public void AdicionarItem(string item)
        {
            if (!Itens.Contains(item) && !string.IsNullOrEmpty(item))
            {
                Itens.Add(item);
            }
        }

        public void AdicionarItem(string item, List<string> list)
        {
            if (!Itens.Contains(item) && !list.Contains(item) && !string.IsNullOrEmpty(item))
            {
                Itens.Add(item);
            }
        }

        public void Clear()
        {
            Itens = new List<string>();
        }

        //Remover itens
        public void RemoverItem(string item)
        {

            if (Itens.Contains(item))
            {
                Itens.Remove(item);
            }
        }
    }
}