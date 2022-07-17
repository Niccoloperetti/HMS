
namespace HMS
{
    public class PatientUserModel : UserModelBase
    {
        #region properties
        public string? PatientId { get; set; }
        public UserModelBase? PatientAssignedDoctor { get; set; }
        public int? PatientDistrict { get; set; }
        public string? PatientSection { get; set; }
        public int? PatientBed { get; set; }
        public string? PatientFileName { get; set; }
        public int? PatientSeverity {get; set; }
        #endregion

        #region constructor
        public PatientUserModel() : base() { }
        public PatientUserModel(string? name, string? surname, string? fiscalCode, DateTime? birthday, string? address,
            string? email, string? phoneNumber, string? patientID, int? patientDistrict, string? patientSection, int? patientBed, string? patientFileName, int? patientSeverity, List<UserModelBase> doctorPatientsList) 
            : base(name, surname, fiscalCode, birthday, address, email, phoneNumber)
        {
            PatientId = patientID;  //TODO: add a way to generate patient IDs
            PatientDistrict = patientDistrict;
            PatientSection = patientSection;
            PatientBed = patientBed;
            PatientFileName = patientFileName;
            PatientSeverity = patientSeverity;
        }
        #endregion
    }
}
