using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazLab1
{
    
        public class User
        {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        string _userid;

        public string UserId
        {
            get { return _userid; }
            set { _userid = value; }
        }
        string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        string _age;

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
    
}
