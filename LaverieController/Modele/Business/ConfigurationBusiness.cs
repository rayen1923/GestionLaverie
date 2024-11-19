using GestionLaverie.Entites;
using LaverieController.Infrastructure;
using LaverieController.Modele.Domaine;

namespace LaverieController.Modele.Business
{
    public class ConfigurationBusiness
    {
        private readonly IProprietaireDAO _proprietaireDao;
        private readonly IMachineDAO _machineDao;

        public ConfigurationBusiness(IProprietaireDAO proprietaireDao)
        {
            _proprietaireDao = proprietaireDao;
        }

        public List<Propriétaire> GetAllPropriétairesWithDetails()
        {
            var proprietaires = _proprietaireDao.GetAllPropriétairesWithDetails();
            return proprietaires ?? new List<Propriétaire>();
        }

        public bool ChangeEtatMachine(int id, int etat)
        {
            var machinechange = _machineDao.ChangeEtat(id,etat);
            return machinechange;
        }
    }
}
