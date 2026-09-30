using System;

namespace CoisasEmprestadas.Models
{
    public enum StatusEmprestimo
    {
        EmDia,
        Atrasado,
        Devolvido
    }

    public class Emprestimo
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public string NomeAmigo { get; set; }
        public string ContatoAmigo { get; set; }
        public DateTime DataCombinadaDevolucao { get; set; }
        public DateTime? DataDevolucaoReal { get; set; }

        public StatusEmprestimo Status
        {
            get
            {
                if (DataDevolucaoReal.HasValue)
                    return StatusEmprestimo.Devolvido;

                if (DateTime.Today > DataCombinadaDevolucao.Date)
                    return StatusEmprestimo.Atrasado;

                return StatusEmprestimo.EmDia;
            }
        }
    }
}