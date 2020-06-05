﻿using CursosOnline.Domain.Curso.Enum;
using System;

namespace CursosOnline.Domain.Curso
{
    public class Curso
    {
        public Curso(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, double valor, string descricao)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
            Descricao = descricao;

            ValidarNome(nome);
            ValidarCargaHoraria(cargaHoraria);
            ValidarValor(valor);
            ValidarDescricao(descricao);
        }

        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; private set; }
        public double Valor { get; private set; }
        public string Descricao { get; private set; }

        public void ValidarNome(string nome)
        {
            if (nome == string.Empty || nome == null)
                throw new ArgumentException("Nome invalido");
        }

        public void ValidarCargaHoraria(double cargaHoraria)
        {
            if (cargaHoraria <= 0)
                throw new ArgumentException("Carga horária não pode ser menor que 0 horas");
        }

        public void ValidarValor(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do curso não pode ser menor que 0 reais");
        }

        public void ValidarDescricao(string descricao)
        {
            if (descricao == string.Empty || descricao == null)
                throw new ArgumentException("A descrição não pode estar em branco");
        }
    }
}

