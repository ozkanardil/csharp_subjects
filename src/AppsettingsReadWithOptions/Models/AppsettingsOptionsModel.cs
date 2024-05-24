namespace AppsettingsReadWithOptions.Models
{
    public class AppsettingsOptionsModel
    {
        public string DbConnString { get; set; }
        public AppsettingsSubsettingsModel? SubSettings { get; set; }
    }

    public class AppsettingsSubsettingsModel
    {
        public string Name { get; set; }
        public string ApiVersion { get; set; }
    }
}
