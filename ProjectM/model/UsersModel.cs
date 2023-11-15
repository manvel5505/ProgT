using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectM.model
{
    [Table("UserTab")]
    internal class UsersModel<T>
    {
        private T username, password, repeatpassword;

        #region Values
        
        [Key]
        [Required(ErrorMessage = "Username Required!")]
        [StringLength(12, MinimumLength = 2, ErrorMessage = "Username size 2 - 12 simbols!")]
        [RegularExpression(pattern: @"[A-Za-z]{0,20}", ErrorMessage = "Username contains invalid simbols!")]
        public T Username
        {
            get { return username; }
            set => username = value;
        }

        [Required(ErrorMessage = "Password Required!")]
        [StringLength(8, MinimumLength = 6, ErrorMessage = "Password size 6 - 8 simbols!")]
        [RegularExpression(pattern: @"[A-Za-z0-9]{0,20}", ErrorMessage = "Password contains invalid simbols!")]
        public T Password 
        { 
            get { return password; } 
            set => password = value; 
        }

        [Required(ErrorMessage = "Repeat Password Required!")]
        [Compare(otherProperty: "Password", ErrorMessage = "Repeat Password not eqouals!")]
        public T RepeatPassword 
        { 
            get { return repeatpassword; } 
            set => repeatpassword = value; 
        }

        #endregion

        public override int GetHashCode()
        {
            return new StringBuilder().Append(Username.ToString() + Password.ToString() + RepeatPassword.ToString()).GetHashCode();
        }
        public override String ToString()
        {
            return Username + " " + Password + " " + RepeatPassword;
        }
    }
}
