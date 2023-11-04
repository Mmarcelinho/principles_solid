using Principios_SOLID.DIP.Solucao.Interfaces;

namespace Principios_SOLID.DIP.Solucao;

    public class LojaServices : ILojaServices
    {

        private readonly ICEPServices _cepServices;
        private readonly ILojaRepository _lojaRepository;

        public LojaServices(ICEPServices cepServices, ILojaRepository lojaRepository)
        {
            _cepServices = cepServices;
            _lojaRepository = lojaRepository;
        }
        public Loja CriarLoja(Loja loja, string cep)
        {
            loja.Endereco = _cepServices.GetEndereco(cep);
            return loja;
        }

        public void AdicionarLoja(Loja loja)
        {
               _lojaRepository.AdicionarLoja(loja);
        }
    }
