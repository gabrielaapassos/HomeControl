using Model.Items;
using System;

public class ConsumoService
{
    public class Consumoservice
    {
        private readonly List<ProdutoConsumido> _consumos;

        public Consumoservice()
        {
            _consumos = new List<ProdutoConsumido>();
        }

        public void RegistrarConsumo(ProdutoConsumido consumo)
        {
            try
            {
                if (consumo == null)
                    throw new ArgumentNullException(nameof(consumo), "O consumo não pode ser nulo.");

                if (consumo.QuantidadeConsumida <= 0)
                    throw new ArgumentException("A quantidade consumida deve ser maior que zero.");

                if (consumo.Item == null)
                    throw new ArgumentException("O item consumido deve ser válido.");

                _consumos.Add(consumo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar consumo: {ex.Message}");
            }
        }

        public IEnumerable<ProdutoConsumido> ObterConsumosPorPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                if (dataInicial > dataFinal)
                    throw new ArgumentException("A data inicial não pode ser maior que a data final.");

                return _consumos.Where(c => c.DataConsumo >= dataInicial && c.DataConsumo <= dataFinal).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter consumos por período: {ex.Message}");
                return Enumerable.Empty<ProdutoConsumido>();
            }
        }
    }
}