using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration_LambdaExpression
{
    public class Patterns
    {
        public Func<string, string, bool> IsValidPasswordRule = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> IsValidFirstName = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> IsValidLastName = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> IsValidEmail = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> IsValidPhoneNo = (x, y) => Regex.IsMatch(x, y);
    }
}
