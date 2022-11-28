using ENISNC.Models;

namespace ENISNC.ViewModels
{
    public class DemandePfeViewModel
    {
        public DemandePFE? demandePFE{ get; set; }
        public List<User>? users { get; set; }
        public DemandePfeViewModel(){}
        public DemandePfeViewModel(DemandePFE demandePFE, List<User> users) 
        {
            this.demandePFE = demandePFE;
            this.users = users;
        }

    }
}
