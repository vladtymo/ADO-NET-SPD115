using System.Configuration;
using System.Data;
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
    private SqlConnection connection;

    public HospitalDbManager(string? connectionString = null)
    {
        connectionString ??= ConfigurationManager.ConnectionStrings["HospitalDb"].ConnectionString;

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

        while (reader.Read()) // read next line
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
        reader.Close();

        return list;
    }

    // Get Donations Amount of some Sponsor
    public decimal? GetDonationAmount(string sponsor)
    {
        // SQL injection - можливість вставити SQL скрипт користувача для запуску
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select SUM(Amount) " +
                              "from Donations as d JOIN Sponsors as s ON d.SponsorId = s.Id " +
                              "where s.Name = @sponsorName";

        // Add SQL Parameters
        command.Parameters.Add("@sponsorName", SqlDbType.NVarChar).Value = sponsor;

        // TODO: handle null value
        var result = command.ExecuteScalar();

        if (result is DBNull) return null;
        return (decimal)result;
    }

    // Set Doctor Premium
    public int SetDoctorPremium(int id, decimal value)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "update Doctors " +
                             $"set Premium = @value " +
                             $"where Id = @id";

        command.Parameters.Add("@value", SqlDbType.Money).Value = value;
        command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
        string connStr = ConfigurationManager.ConnectionStrings["HospitalDb"].ConnectionString;
        HospitalDbManager manager = new HospitalDbManager(connStr);

        Console.WriteLine($"Doctors: {manager.GetDoctorsCount()}");

        foreach (var d in manager.GetAllDoctors())
        {
            Console.WriteLine($"[{d.Id}]: {d.Name} {d.Surname} - {d.Salary} + {d.Premium}");
        }

        Console.Write("Enter sponsor name: ");
        string name = Console.ReadLine()!;

        var result = manager.GetDonationAmount(name);

        Console.WriteLine($"{name} donations: {result}$");

        manager.SetDoctorPremium(7, 55);
        //manager.Donate(1678, 10, 8);
    }
}