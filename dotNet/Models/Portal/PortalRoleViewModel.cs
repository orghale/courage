using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XPLUG.WEBTOOLKIT;

namespace LottoGistAdmin.Models.Portal
{
    public class PortalRoleViewModel
    {
        public int TabId { get; set; }
        public int TabParentId { get; set; }
        public int TabOrder { get; set; }
        public int TabType { get; set; }
        public string Title { get; set; }
        public string ContentUrl { get; set; }
        public string LeftPanelUrl { get; set; }
        public string RightPanelUrl { get; set; }
        public string Roles { get; set; }
        public int Status { get; set; }
        public bool StatusVal { get; set; }
        public string StatusName { get; set; }
        public List<NameValueObject> AllRoles { get; set; }
        public int[] MyRoleIds { get; set; }
        public string[] MyRoles { get; set; }
    }

    public class PortalUserViewModel
    {
        public int UserId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsApproved { get; set; }
        public List<NameValueObject> AllRoles { get; set; }
        public int[] MyRoleIds { get; set; }
        public string[] MyRoles { get; set; }
    }
}