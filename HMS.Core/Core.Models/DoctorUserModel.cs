

namespace HMS
{
    public class DoctorUserModel : UserModelBase
    {
        #region properties
        public string? DoctorID { get; set; }
        public int? DoctorRole { get; set; }
        public List<UserModelBase> DoctorPatientsList { get; set; }
        #endregion

        #region constructor
        public DoctorUserModel(){}
        public DoctorUserModel(string? doctorID, int? doctorRole)
        {
            DoctorID = doctorID;//TODO: need to add a DoctorID generator to the ID generator
            DoctorRole = doctorRole;
            DoctorPatientsList = new List<UserModelBase>();
        }
        public DoctorUserModel(string? doctorID, int? doctorRole, List<UserModelBase> doctorPatientsList)
        {
            DoctorID = doctorID;
            DoctorRole = doctorRole;
            DoctorPatientsList = doctorPatientsList;
        }
        #endregion
    }
}
