using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserDetails
    {
        public String firstName;
        public String lastName;
        public String email;
        public String phoneNumber;
        public String password1;
        public String password2;
        public String password3;
        public String password4;
        public String email1;
        public Match FirstName(string firstname, string pattern)
        {
            this.firstName = firstname;


            return Regex.Match(firstName, pattern);

        }
        public Match LastName(string lastname, string pattern)
        {
            this.lastName = lastname;
            // Console.WriteLine("Enter first name" +firstName);

            return Regex.Match(lastName, pattern);

        }
        public Match Email(string email, string pattern)
        {
            this.email = email;


            return Regex.Match(email, pattern);

        }

        public Match PhoneNumber(string phonenumber, string pattern)
        {
            this.phoneNumber = phonenumber;
            return Regex.Match(phoneNumber, pattern);

        }
        public Match Password1(string password, string pattern)
        {
            this.password1 = password;
            return Regex.Match(password, pattern);

        }
        public Match Password2(string password2, string pattern)
        {
            this.password2 = password2;
            return Regex.Match(password2, pattern);

        }
        public Match Password3(string password3, string pattern)
        {
            this.password3 = password3;
            return Regex.Match(password3, pattern);

        }
        public Match Password4(string password4, string pattern)
        {
            this.password4 = password4;
            return Regex.Match(password4, pattern);

        }
        public Match Email1(string email1, string pattern)
        {
            this.email1 = email1;
            return Regex.Match(email1, pattern);

        }

    }
}