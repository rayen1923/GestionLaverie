namespace LaverieController.Modele.Domaine
{
    public interface IMachineDAO
    {
        Boolean ChangeEtat(int id,int nouvelEtat);
    }
}
