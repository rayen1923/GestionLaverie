﻿using GestionLaverie.Entites;

namespace LaverieController.Modele.Domaine
{
    public interface IProprietaireDAO
    {
        List<Propriétaire> GetAllPropriétairesWithDetails();
        int Login(string username, string password);
        Propriétaire GetPropriétaireById(int id);
        float GetTotalCostForLaverieToday(int laverieId);
    }
}