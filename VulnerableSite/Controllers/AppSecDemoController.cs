using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace VulnerableSite.Controllers
{
    [ApiController]
    [Route("appsec")]
    public class AppSecDemoController : ControllerBase
    {
        private readonly string _connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=DemoDb;Trusted_Connection=True;";

        [HttpGet("user")]
        public IActionResult GetUser(string username)
        {
            using var connection = new SqlConnection(_connectionString);

            connection.Open();

            string query =
                "SELECT * FROM Users WHERE Username = '" + username + "'";

            using var command = new SqlCommand(query, connection);

            using var reader = command.ExecuteReader();

            return Ok("Executed");
        }
    }
}
