using University.App.Interfaces;
using University.App.Resources;
using Xamarin.Forms;

namespace University.App.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;


            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept { get { return Resource.Accept; } }
        public static string Notification { get { return Resource.Notification; } }
        public static string NoInternetConnection { get { return Resource.NoInternetConnection; } }
        public static string FieldsRequired { get { return Resource.FieldsRequired; } }
        public static string RegisterSuccessfull { get { return Resource.RegisterSuccessfull; } }
        public static string ChangePasswordSuccessfully { get { return Resource.ChangePasswordSuccessfully; } }
        public static string ProcessSuccessfull { get { return Resource.ProcessSuccessfull; } }
        public static string Bad { get { return Resource.Bad; } }
        public static string Well { get { return Resource.Well; } }
        public static string Acceptable { get { return Resource.Acceptable; } }
        public static string Excellent { get { return Resource.Excellent; } }
   
    
    }
}
