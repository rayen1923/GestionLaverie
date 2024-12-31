using LaverieController.Modele.Domaine;
using MySql.Data.MySqlClient;

namespace LaverieController.Infrastructure
{
    public class LaverieRepoImp : ILaverieDAO
    {
        private readonly string _connectionString = "Server=localhost;Database=laverie;Uid=root;Pwd=;";
        public float GetTotalCostForLaverieToday(int laverieId)
        {
            float totalCost = 0;

            string query = @"
                        SELECT SUM(c.Cout) AS TotalCost
                        FROM cycle_history ch
                        INNER JOIN Machines m ON ch.MachineId = m.Id
                        INNER JOIN Cycles c ON ch.CycleId = c.Id
                        WHERE m.LaverieId = @laverieId AND DATE(ch.Timestamp) = CURDATE()";

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@laverieId", laverieId);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalCost = Convert.ToSingle(result);
                    }
                }
            }

            return totalCost;
        }
    }
}
