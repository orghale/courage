using System.Collections.Generic;


namespace LottoGistAdmin.DataAccess.RemoteModel
{
    public class RegUserObj : UserAuthObj
    {
        public string FullName { get; set; }
        public int Gender { get; set; }
        public string DateOfBirth { get; set; }
        public int StateOfLocationId { get; set; }
        public int LgaOfLocationId { get; set; }
        public string CityOfLocation { get; set; }
        public string MembershipNumber { get; set; }
        public string ScreenName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string AccessCode { get; set; }
        public int Status { get; set; }

    }

    public class EditUserObj : UserAuthObj
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public int Gender { get; set; }
        public string DateOfBirth { get; set; }
        public int StateOfLocationId { get; set; }
        public int LgaOfLocationId { get; set; }
        public string CityOfLocation { get; set; }
        public string MembershipNumber { get; set; }
        public string ScreenName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string AccessCode { get; set; }
        public int Status { get; set; }

    }

    public class UsersLoginObj
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoginSourceIP { get; set; }
    }

    //***************************** Response Objects  **********************************
    public class UsersSearchObj : UserAuthObj
    {
        public List<UserItemObj> Users { get; set; }
        public APIResponseStatus Status { get; set; }
    }


    public class UserItemObj
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public int Gender { get; set; }
        public string GenderLabel { get; set; }
        public string DateOfBirth { get; set; }
        public int StateOfLocationId { get; set; }
        public string StateOfLocation { get; set; }
        public int LgaOfLocationId { get; set; }
        public string LgaOfLocation { get; set; }
        public string CityOfLocation { get; set; }
        public string MembershipNumber { get; set; }
        public string ScreenName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string AccessCode { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusLabel { get; set; }
    }

}