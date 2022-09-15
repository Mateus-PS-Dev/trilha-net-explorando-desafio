namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            // Implementado!!!
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implementado!!!
                throw new Exception("Quantidade de hospedes não suportada.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado!!!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado!!!
            /*
            Ficou meio confuso aqui, pois não entendi se foi pedido o valor da diária (unidade) ou valor total. Interpretei como valor total dos dias reservados como no vídeo.
            */ 
            decimal valor = Suite.ValorDiaria * DiasReservados;

            // Implementado!!!
            if (DiasReservados >= 10)
            {
                valor = Suite.ValorDiaria * DiasReservados * 0.10M;
            }

            return valor;
        }
    }
}