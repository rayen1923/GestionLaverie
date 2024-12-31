namespace LaverieController.Modele.Domaine
{
    public interface IMachineDAO
    {
        float GetTotalCostForMachineToday(int machineId);
        bool UpdateMachineEtat(int machineId, int cycleId);
    }
}
