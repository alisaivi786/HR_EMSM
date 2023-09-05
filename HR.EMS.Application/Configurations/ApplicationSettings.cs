
namespace HR.EMS.Application.Configurations;

public class ApplicationSettings
{

    public ConnectionStrings ConnectionString = new()
    {
        //SqlConnection = "Data Source =85.13.199.236,58641;Initial Catalog=HR_EMS_AB; User ID=knowb4;Password=>^#2G{2ZVHyaUB^;TrustServerCertificate=True;Connect Timeout=120;",
        SqlConnection = "Data Source =LAPTOP-4RV3RVOH\\SQLEXPRESS;Initial Catalog=HR_EMS; User ID=jams;Password=admin12345;encrypt=false",
    };
    public DbProvider DbProvider = new()
    {
        Value = "SqlServer"
    };

    public string TokenSecret = "C0224489-FEF2-4D71-B8E3-F24E54E2CCA8";
    public string PasswordSaltKey = "C0224489-FEF2-4D71-B8E3-F24E54E2CCA8";
    public string FileLogsPath = "D:\\HR_EMS_LOGS\\generalLogFilePath.txt";
}

public class ConnectionStrings
{
    public string SqlConnection { get; set; } = "Data Source =LAPTOP-4RV3RVOH\\SQLEXPRESS;Initial Catalog=EMS; User ID=jams;Password=admin12345;encrypt=false";
}
public class DbProvider
{
    public string Value { get; set; } = "SqlServer";

}