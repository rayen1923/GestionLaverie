using GestionLaverie.Entites;
using LaverieController.Modele.Domaine;

namespace LaverieController.Modele.Business
{
    public class ConfigurationBusiness
    {
        private readonly IProprietaireDAO _proprietaireDao;

        public ConfigurationBusiness(IProprietaireDAO proprietaireDao)
        {
            _proprietaireDao = proprietaireDao;
        }

        public List<Propriétaire> GetAllPropriétairesWithDetails()
        {
            var proprietaires = _proprietaireDao.GetAllPropriétairesWithDetails();
            return proprietaires ?? new List<Propriétaire>();
        }

        public int Login(string username, string password)
        {
            return _proprietaireDao.Login(username, password);
        }
        public Propriétaire GetPropriétaireById(int id)
        {
            return _proprietaireDao.GetPropriétaireById(id);
        }
        public float GetTotalCostForLaverieToday(int laverieId)
        {
            return _proprietaireDao.GetTotalCostForLaverieToday(laverieId);
        }
    }
}
