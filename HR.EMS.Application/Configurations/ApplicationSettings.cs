
namespace HR.EMS.Application.Configurations;

public class ApplicationSettings
{

    public ConnectionStrings ConnectionString = new()
    {
        SqlConnection = "Data Source =85.13.199.236,58641;Initial Catalog=HR_EMS; User ID=knowb4;Password=>^#2G{2ZVHyaUB^;TrustServerCertificate=True;Connect Timeout=120;",
        //SqlConnection = "Data Source =LAPTOP-4RV3RVOH\\SQLEXPRESS;Initial Catalog=HR_EMS; User ID=jams;Password=admin12345;encrypt=false",
    };
    public DbProvider DbProvider = new()
    {
        Value = "SqlServer"
    };

    public string TokenSecret = "C0224489-FEF2-4D71-B8E3-F24E54E2CCA8";
    public string PasswordSaltKey = "C0224489-FEF2-4D71-B8E3-F24E54E2CCA8";
}

public class ConnectionStrings
{
    public string SqlConnection { get; set; } = "Data Source =LAPTOP-4RV3RVOH\\SQLEXPRESS;Initial Catalog=EMS; User ID=jams;Password=admin12345;encrypt=false";
    public string Sqlite { get; set; } = "Data Source=EpicLoan.db;Cache=Shared";
    public string Npgsql { get; set; } = "Host=myserver;Username=mylogin;Password=mypass;Database=mydatabase";
    public string Oracle { get; set; } = "User Id=<USER ID>;Password=<PASSWORD>;Data Source=<Data Source>;";
    public string SqlConnectionLocal { get; set; } = string.Empty;
}
public class DbProvider
{
    public string Value { get; set; } = "SqlServer";

}