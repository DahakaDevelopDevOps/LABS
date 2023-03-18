using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace OOP_Lab02
{
    public class Validators // собственные валидаторы на ValidationAttribute
    {

        #region Валидатор почтового индекса
        public class UDKValidation : ValidationAttribute
        {
            public Regex regex = new Regex(@"[0-9]{1,3}.[0-9]{1,3}.([0-9]{1,3})?$");
            public override bool IsValid(object value)
            {
                if (regex.IsMatch((string)value))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool IsValidStr(string value)
            {
                if (regex.IsMatch((string)value))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

    }


}
