
namespace HMS
{
    public class AdminUserModel: UserModelBase
    {
        #region properties
        public string? AdminID { get; set; }
        public int? AdminLevel { get; set; }
        public int? AdminDistrict { get; set; }
        public string? AdminSection { get; set; }
        #endregion

        #region constructor
        public AdminUserModel() : base() {}
        public AdminUserModel(string? name, string? surname, string? fiscalCode, DateTime? birthday, string? address,
            string? email, string? phoneNumber, string? adminID, int? adminLevel, int? adminDistrict, string? adminSection) : base(name, surname, fiscalCode, birthday, address, email, phoneNumber)
        {
            AdminID = adminID;
            AdminLevel = adminLevel;
            AdminDistrict = adminDistrict;
            AdminSection = adminSection;
        }

        #endregion
    }
}
