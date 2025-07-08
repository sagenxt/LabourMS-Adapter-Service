using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labour.MS.Adapter.Repository.Constants
{
    public class DbConstants
    {
        #region "Establishment"

        #region "Stored Procedure Parameters"

        public const string P_ESTABLISHMENT_ID = "Establishment_Id";
        public const string P_ESTABLISHMENT_NAME = "Establishment_Name";
        public const string P_CONTACT_PERSON = "Contact_Person";
        public const string P_EMAIL_ID = "Email_Id";
        public const string P_MOBILE_NUMBER = "Mobile_Number";
        public const string P_DOOR_NUMBER = "Door_Number";
        public const string P_STREET = "Street";
        public const string P_STATE_ID = "State_Id";
        public const string P_STATE_CODE = "State_Code";
        public const string P_DISTRICT_ID = "District_Id";
        public const string P_DISTRICT_CODE = "District_Code";
        public const string P_CITY_ID = "City_Id";
        public const string P_CITY_CODE = "City_Code";
        public const string P_VILLAGE_AREA_ID = "Village_Area_Id";
        public const string P_VILLAGE_AREA_Code = "Village_Area_Code";
        public const string P_VILLAGE_AREA = "Village_Area";
        public const string P_PINCODE = "Pincode";
        public const string P_IS_PLAN_APPROVAL_ID = "Is_Plan_Approval_Id";
        public const string P_PLAN_APPROVAL_ID = "Plan_Approval_Id";
        public const string P_CATEGORY_ID = "Category_Id";
        public const string P_WORK_NATURE_ID = "Work_Nature_Id";
        public const string P_COMMENCEMENT_DATE = "Commencement_Date";
        public const string P_COMPLETION_DATE = "Completion_Date";
        public const string P_CONSTRUCTION_ESTIMATED_COST = "Construction_Estimated_Cost";
        public const string P_CONSTRUCTION_AREA = "Construction_Area";
        public const string P_BUILT_UP_AREA = "Built_Up_Area";
        public const string P_BASIC_ESTIMATED_COST = "Basic_Estimated_Cost";
        public const string P_NO_OF_MALE_WORKERS = "No_Of_Male_Workers";
        public const string P_NO_OF_FEMALE_WORKERS = "No_Of_Female_Workers";
        public const string P_IS_ACCEPTED_TERMS_CONDITIONS = "Is_Accepted_Terms_Conditions";



        #endregion

        #region "Stored Procedure Names"

        public const string USP_PERSIST_ESTABLISHMENT_DETAILS = "usp_Persist_Establishment_Details";
        public const string USP_GET_ALL_ESTABLISHMENT_DETAILS = "usp_Get_All_Establishment_Details";
        public const string USP_GET_ESTABLISHMENT_DETAILS = "usp_Get_Establishment_Details";

        public const string Get_Cities = "Get_Cities";
        public const string Get_Districts = "Get_Districts";
        public const string Get_Villages_Areas = "Get_Villages_Areas";


        #endregion

        #endregion

        #region "Worker"


        #endregion

        #region "Common Stored Procedure Parameters"

        public const string P_STATUS_CODE = "StatusCode";
        public const string P_MESSAGE = "Message";


        #endregion
    }
}
