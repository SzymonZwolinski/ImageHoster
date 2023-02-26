using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManager.Domain.Models
{
	public class Users
	{
		public Guid Id { get; }
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string UserName { get; private set; }
		public IEnumerable<UsersRoles> Roles => _roles;
		private HashSet<UsersRoles> _roles { get; set; }

		public Users() { }

		public Users(
			string firstName,
			string lastName,
			string userName)
		{
			SetFirstName(firstName);
			SetLastName(lastName);
			SetUserName(userName);
		}

		private void SetFirstName(string firstName) 
		{
			if(string.IsNullOrWhiteSpace(firstName))
			{
				throw new ArgumentNullException("FirstName can not be null or whitespace");
			}

			if(firstName.Length > 63)
			{
				throw new ArgumentOutOfRangeException("FirstName can not be longer than 63 characters");
			}

			FirstName = firstName;
		}

		private void SetLastName(string lastName)
		{
			if (string.IsNullOrWhiteSpace(lastName))
			{
				throw new ArgumentNullException("LastName can not be null or whitespace");

			}

			if(lastName.Length > 63)
			{
				throw new ArgumentOutOfRangeException("LastName can not be longer than 63 characters");
			}

			LastName = lastName;
		}

		private void SetUserName(string userName) 
		{
			if (string.IsNullOrWhiteSpace(userName))
			{
				throw new ArgumentNullException("UserName can not be null or whitespace");
			}

			if(UserName.Length > 31)
			{
				throw new ArgumentOutOfRangeException("UserName can not be longer than 32 characters");
			}

			UserName = userName;
		}
	}
}
