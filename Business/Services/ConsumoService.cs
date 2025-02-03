//using Model.Items;
//using HomeControl.EFCore.Data;
//using System;
//using Models.Items;

//namespace HomeControl.Business.Services
//{
//    public class Consumoservice
//    {
//        private readonly DataContext _context;

//        public Consumoservice(DataContext context)
//        {
//            _context = context;
//        }

//        public void RegistrarConsumo(ItemEstoque item, int quantidadeConsumida)
//        {
//            try
//            {
//                var consumo = new ProdutoConsumido
//                {
//                    Item = item,
//                    QuantidadeConsumida = quantidadeConsumida,
//                    DataConsumo = DateTime.Now
//                };
//                if (consumo == null)
//                    throw new ArgumentNullException(nameof(consumo), "O consumo não pode ser nulo.");

//                if (consumo.QuantidadeConsumida <= 0)
//                    throw new ArgumentException("A quantidade consumida deve ser maior que zero.");

//                if (consumo.Item == null)
//                    throw new ArgumentException("O item consumido deve ser válido.");

//                _context.Consumos.Add(consumo);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Erro ao registrar consumo: {ex.Message}");
//            }
//        }

//        public IEnumerable<ProdutoConsumido> ObterConsumosPorPeriodo(DateTime dataInicial, DateTime dataFinal)
//        {
//            try
//            {
//                if (dataInicial > dataFinal)
//                    throw new ArgumentException("A data inicial não pode ser maior que a data final.");

//                return _context.Consumos.Where(c => c.DataConsumo >= dataInicial && c.DataConsumo <= dataFinal).ToList();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Erro ao obter consumos por período: {ex.Message}");
//                return Enumerable.Empty<ProdutoConsumido>();
//            }
//        }
//    }
//}