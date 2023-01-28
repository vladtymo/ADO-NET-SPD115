using System.Data.SqlClient;

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }
    public decimal Premium { get; set; }
}

public class HospitalDbManager
{
    private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hospital_lab_6;Integrated Security=True;";
    private SqlConnection connection;

    public HospitalDbManager()
    {
        connection = new SqlConnection(connectionString);
        connection.Open();
    }

    // --------------- public interface ---------------

    // Get Doctors Count
    public int GetDoctorsCount()
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select COUNT(Id) from Doctors";

        return (int)command.ExecuteScalar();
    }

    // Get All Doctors
    public List<Doctor> GetAllDoctors()
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select * from Doctors";

        SqlDataReader reader = command.ExecuteReader();

        List<Doctor> list = new List<Doctor>();

        while (reader.Read())
        {
            list.Add(new Doctor()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Surname = (string)reader["Surname"],
                Salary = (decimal)reader["Salary"],
                Premium = (decimal)reader["Premium"]
            });
        }

        return list;
    }

    // Get Donations Amount of some Sponsor
    public decimal? GetDonationAmount(string sponsor)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select SUM(Amount) " +
                              "from Donations as d JOIN Sponsors as s ON d.SponsorId = s.Id " +
                              $"where s.Name = '{sponsor}'";

        // TODO: handle null value
        return (decimal?)command.ExecuteScalar();
    }

    // Set Doctor Premium
    public int SetDoctorPremium(int id, decimal value)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "update Doctors " +
                             $"set Premium = {value} " +
                             $"where Id = {id}";

        return command.ExecuteNonQuery();
    }

    // Add Donation
    public int Donate(decimal amount, int departmentId, int sponsorId)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "insert Donations " +
                             $"values ({amount}, '{DateTime.Now:yyyy/MM/dd}', {departmentId}, {sponsorId})";

        return command.ExecuteNonQuery();
    }

    // TODO: Delete Examinations by Date
}

internal class Program
{
    private static void Main(string[] args)
    {
        HospitalDbManager manager = new HospitalDbManager();

        Console.WriteLine($"Doctors: {manager.GetDoctorsCount()}");

        //foreach (var d in manager.GetAllDoctors())
        //{
        //    Console.WriteLine($"[{d.Id}]: {d.Name} {d.Surname} - {d.Salary} + {d.Premium}");
        //}

        Console.WriteLine($"Microsoft donations: {manager.GetDonationAmount("Microsoft")}$");

        manager.SetDoctorPremium(7, 55);
        manager.Donate(1678, 10, 8);
    }
}