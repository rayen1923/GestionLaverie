using LaverieController.Modele.Domaine;
using MySql.Data.MySqlClient;

namespace LaverieController.Infrastructure
{
    public class MachineRepoImp : IMachineDAO
    {
        private readonly string _connectionString = "Server=localhost;Database=laverie;Uid=root;Pwd=;";

        public bool ChangeEtat(int id,int nouvelEtat)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Machines SET Etat = @Etat WHERE Id = @Id";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Etat", nouvelEtat);
                        command.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la modification de l'état : {ex.Message}");
                return false;
            }
        }
    }
}