using System;
using System.Collections.Generic;
using System.Text;
using University.App.Helpers;

namespace University.App.ViewModels.Forms
{
    public class PQRSViewModel : BaseViewModel
    {
        #region Attributes
        public class TypeRequest
        {
            public string Name { get; set; }
        }
        public class RateService
        {
            public string Name { get; set; }
        }


        private List<TypeRequest> _typeRequests;
        private List<RateService> _rateServices;
        #endregion



        #region Properties
        public List<TypeRequest> TypeRequests
        {
            get { return this._typeRequests; }
            set { this.SetValue(ref this._typeRequests, value); }
        }
        public List<RateService> RateServices
        {
            get { return this._rateServices; }
            set { this.SetValue(ref this._rateServices, value); }
        }
        #endregion



        #region Constructor
        public PQRSViewModel()
        {
            this.LoadTypeRequests();
            this.LoadRateServices();
        }
        #endregion
        #region Methods
        private void LoadTypeRequests()
        {
            this.TypeRequests = new List<TypeRequest>
            {
                new TypeRequest { Name = "Petition" },
                new TypeRequest { Name = "Complain" },
                new TypeRequest { Name = "Claim" },
                new TypeRequest { Name = "Suggestion" }
            };
        }
        private void LoadRateServices()
        {
            this.RateServices = new List<RateService>
            {
                new RateService { Name = Languages.Bad },
                new RateService { Name = "Regular" },
                new RateService { Name = Languages.Well },
                new RateService { Name = Languages.Acceptable },
                new RateService { Name = Languages.Excellent }
            };
        }
        #endregion
    }
}