﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimAcher.Infra;


namespace MimAcher.Aplicacao
{
    public class GestorDeUsuario
    {
        public RepositorioDeUsuario RepositorioDeUsuario { get; set; }

        public GestorDeUsuario(){
            this.RepositorioDeUsuario = new RepositorioDeUsuario();
        }

        public MA_USUARIO ObterUsuarioPorId(int id)
        {
            return this.RepositorioDeUsuario.ObterUsuarioPorId(id);
        }

        public List<MA_USUARIO> ObterTodosOsUsuarios()
        {
            return this.RepositorioDeUsuario.ObterTodosOsUsuarios();
        }

        public MA_USUARIO ObterUsuarioPorLogin(String login)
        {
            return this.RepositorioDeUsuario.ObterUsuarioPorLogin(login);
        }

        public MA_USUARIO ObterUsuarioPorLoginESenha(String login, String senha)
        {
            return this.RepositorioDeUsuario.ObterUsuarioPorLoginESenha(login, senha);
        }

        public Boolean VerificarExistenciaDeUsuarioPorLoginESenha(String login, String senha)
        {
            if(ObterUsuarioPorLoginESenha(login, senha) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InserirUsuario(MA_USUARIO usuario)
        {
            this.RepositorioDeUsuario.InserirUsuario(usuario);
        }

        public int BuscarQuantidadeRegistros()
        {
            return this.RepositorioDeUsuario.BuscarQuantidadeRegistros();
        }

        public void RemoverUsuario(MA_USUARIO usuario)
        {
            this.RepositorioDeUsuario.RemoverUsuario(usuario);
        }

        public void AtualizarUsuario(MA_USUARIO usuario)
        {
            this.RepositorioDeUsuario.AtualizarUsuario(usuario);
        }
    }
}