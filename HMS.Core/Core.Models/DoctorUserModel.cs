

namespace HMS
{
    public class DoctorUserModel : UserModelBase
    {
        #region properties
        public string? DoctorID { get; set; }
        public int? DoctorRole { get; set; }
        public string? DoctorSection { get; set; }
        public List<UserModelBase> DoctorPatientsList { get; set; }
        #endregion

        #region constructor
        public DoctorUserModel() : base(){}
        public DoctorUserModel(string? name, string? surname, string? fiscalCode, DateTime? birthday, string? address,
            string? email, string? phoneNumber, string? doctorID, int? doctorRole, string? doctorSection) 
            : base(name, surname, fiscalCode, birthday, address, email, phoneNumber)
        {
            DoctorID = doctorID;//TODO: need to add a DoctorID generator to the ID generator
            DoctorRole = doctorRole;
            DoctorSection = doctorSection;
            DoctorPatientsList = new List<UserModelBase>();
        }
        public DoctorUserModel(string? name, string? surname, string? fiscalCode, DateTime? birthday, string? address,
            string? email, string? phoneNumber, string? doctorID, int? doctorRole, string? doctorSection, List<UserModelBase> doctorPatientsList) 
            : base(name, surname, fiscalCode, birthday, address, email, phoneNumber)
        {
            DoctorID = doctorID;
            DoctorRole = doctorRole;
            DoctorSection = doctorSection;
            DoctorPatientsList = doctorPatientsList;      
        }
        #endregion
    }
}
