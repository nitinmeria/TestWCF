using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            WSSRManageWebAccount.ManageWebAccountServiceClient proxy = new WSSRManageWebAccount.ManageWebAccountServiceClient();
            WSSRManageWebAccount.SupporterProfileDetails profile = new WSSRManageWebAccount.SupporterProfileDetails();
            profile.email = "asdasasd";
            WSSRManageWebAccount.SupporterProfileDetailsReponse response = new WSSRManageWebAccount.SupporterProfileDetailsReponse();
            response = proxy.UpdateSupporterProfileDetails(profile);
        }
    }
}
