﻿namespace M03S09.Jogos.WebApi.DTOs.Estudios
{
    public class ViewEstudioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
