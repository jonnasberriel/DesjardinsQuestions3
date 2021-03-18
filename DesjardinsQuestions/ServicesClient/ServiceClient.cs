using System;
using DesjardinsQuestion3.Services;

namespace DesjardinsQuestion3.ServicesClient
{
    public class ServiceClient : IServiceClient
    {
        private readonly IService _service;

        private bool _traitementEnErreur;
        public ServiceClient(IService service)
        {
            _service = service;
        }

        public bool EffectuerTraitementUneFois()
        {
            try
            {
                _traitementEnErreur = _service.TraitementEnSuccess();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _traitementEnErreur;
        }

        public bool EffectuerTraitementQuatreFois()
        {
            try
            {
                var i = 1;
                do
                {
                    _traitementEnErreur = _service.TraitementEnSuccess();
                    i++;
                } while (i < 5);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _traitementEnErreur;
        }
    }
}
