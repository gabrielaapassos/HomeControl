using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public class User
    {
        public User(int? userId, string name, string email, string password)
        {
            UserId = userId;
            Name = name;
            Email = email;
            Password = password;
        }
		public int? UserId{ get; set;}
        public string Name { get; set;}
        public string Email { get; set;}
        public string Password { get; set;}

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType != GetType()) return false;
            var other = (User)obj;

            return base.Equals(
                User.HasValue && other.UserId.HasValue && UserId == other.UserId   
             );

        }

    }
}
