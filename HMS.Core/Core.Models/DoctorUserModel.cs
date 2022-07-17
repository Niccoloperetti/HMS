

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
        public DoctorUserModel() : base(){}
        public DoctorUserModel(string? name, string? surname, string? fiscalCode, DateTime? birthday, string? address,
            string? email, string? phoneNumber, string? doctorID, int? doctorRole) 
            : base(name, surname, fiscalCode, birthday, address, email, phoneNumber)
        {
            DoctorID = doctorID;//TODO: need to add a DoctorID generator to the ID generator
            DoctorRole = doctorRole;
            DoctorPatientsList = new List<UserModelBase>();
        }
        public DoctorUserModel(string? name, string? surname, string? fiscalCode, DateTime? birthday, string? address,
            string? email, string? phoneNumber, string? doctorID, int? doctorRole, List<UserModelBase> doctorPatientsList) 
            : base(name, surname, fiscalCode, birthday, address, email, phoneNumber)
        {
            DoctorID = doctorID;
            DoctorRole = doctorRole;
            DoctorPatientsList = doctorPatientsList;
        }
        #endregion
    }
}
