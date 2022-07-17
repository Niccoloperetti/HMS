
namespace HMS
{
    public class AdminUserModel: UserModelBase
    {
        #region properties
        public string? AdminID { get; set; }
        public int? AdminLevel { get; set; }
        #endregion

        #region constructor
        public AdminUserModel() : base() {}
        public AdminUserModel(string? name, string? surname, string? fiscalCode, DateTime? birthday, string? address,
            string? email, string? phoneNumber, string? adminID, int? adminLevel) : base(name, surname, fiscalCode, birthday, address, email, phoneNumber)
        {
            AdminID = adminID;
            AdminLevel = adminLevel;
        }

        #endregion
    }
}
