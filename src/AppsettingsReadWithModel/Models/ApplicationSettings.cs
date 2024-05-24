using System;

namespace AppsettingsReadWithModel.Models
{
    public class ApplicationSettings
    {
       
        public static string DbConnString { get; set; }
        public static AppsettingsSubsettingsModel SubSettings { get; set; } = new AppsettingsSubsettingsModel();
    }

    public class AppsettingsSubsettingsModel
    {
        public string Name { get; set; }
        public string ApiVersion { get; set; }
    }

}
