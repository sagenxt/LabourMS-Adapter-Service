﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labour.MS.Adapter.Utility.Constants
{
    public class ApiInfoConstant
    {
        public const string Name = "labourms";
        public const string Version = "v1";
        public const string SubBasePath = "services";
        public const string Adapter = "adapter";
        public const string Establishment = "establishment";
        public const string EstablishmentDetails = "establishment/details";
        public const string EstablishmentAllDetails = "establishment/alldetails";

        public const string VillagesAreasAllDetails = "villagesareas/details";
        public const string VillageAreaDetailsById = "villagesareas/detailsbyId";
        public const string VillagesAreasDetailsByCityId = "villagesareas/villagesareasdetailsbycityid";

        public const string CitiesAllDetails = "cities/details";
        public const string CityDetailsById = "cities/detailsbyId";
        public const string CitiesDetailsByDistrictId = "cities/citiesdetailsbydistrictid";

        public const string DistrictsAllDetails = "districts/details";
        public const string DistrictDetailsById = "districts/detailsbyId";
        public const string DistrictsDetailsByStateId = "districts/districtsdetailsbystateid";

        #region "Application Connection String Name/Key"

        public const string NameOfConnectionString = "AppConnectionString";

        #endregion
    }
}
