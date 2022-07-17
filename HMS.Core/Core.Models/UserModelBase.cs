
namespace HMS
{
    public abstract class UserModelBase
    {
        #region properties
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FiscalCode { get; set; }  
        public DateTime? Birthday { get; set; }
        public string? Address { get; set; } 
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? UserId { get; set; }
        public string? UserPassword { get; set; }
        public DateTime? Created { get; set; }

        //TODO: sections and districts can be probably moved here, it would be a more sensible and correct choice
        #endregion

        #region constructor
        public UserModelBase() 
        {
            Created = DateTime.Now;
        }

        public UserModelBase(string? name, string? surname, string? fiscalCode, DateTime? birthday, string? address, string? email, string? phoneNumber)
        {
            Name = name;
            Surname = surname;
            FiscalCode = fiscalCode;
            Birthday = birthday;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            // TODO: create id generator for UserID assign, needs to return a nullable
            Created = DateTime.Now;
        }
        #endregion
    }
}
