using LaverieController.Modele.Domaine;

namespace LaverieController.Modele.Business
{
    public class LaverieBusiness
    {
        private readonly ILaverieDAO _proprietaireDao;

        public LaverieBusiness(ILaverieDAO LaverieDao)
        {
            _proprietaireDao = LaverieDao;
        }
        public float GetTotalCostForLaverieToday(int laverieId)
        {
            return _proprietaireDao.GetTotalCostForLaverieToday(laverieId);
        }
    }
}
