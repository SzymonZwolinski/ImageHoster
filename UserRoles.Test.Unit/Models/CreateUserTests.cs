using Shouldly;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersManager.Domain.Models;
using Xunit;

namespace UserRoles.Test.Unit.Models
{
	public class Users
	{
		private UsersManager.Domain.Models.Users Act(
			string FirstName,
			string LastName,
			string UserName)
			=> new UsersManager.Domain.Models.Users(
				FirstName,
				LastName,
				UserName);
		
		[Fact]
		public void given_valid_data_user_should_be_created()
		{
			//Arrange

			//Act
			var user = Act(
							firstName,
							lastName,
							userName);

			//Assert
			user.ShouldNotBeNull();

			user.FirstName.ShouldBe(firstName);
			user.LastName.ShouldBe(lastName);
			user.UserName.ShouldBe(userName);
		}

		[Fact]
		public void given_null_firstName_should_throw_an_exception()
		{
			//Arrange

			//Act
			var exception = Record.Exception(() => Act(
														null,
														lastName,
														userName));

			//Assert
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_whitespace_firstName_should_throw_an_exception()
		{
			//Arrange

			//Act
			var exception = Record.Exception(() => Act(
														"",
														lastName,
														userName));

			//Assert
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_null_lastName_should_throw_an_exception()
		{
			//Arrange

			//Act
			var exception = Record.Exception(() => Act(
														firstName,
														null,
														userName));

			//Assert
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_whitespace_lastName_should_throw_an_exception()
		{
			//Arrange

			//Act
			var exception = Record.Exception(() => Act(
														firstName,
														"",
														userName));

			//Assert
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_null_userName_should_throw_an_exception()
		{
			//Arrange

			//Act
			var exception = Record.Exception(() => Act(
														firstName,
														lastName,
														null));

			//Assert
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_whitespace_userName_should_throw_an_exception()
		{
			//Arrange

			//Act
			var exception = Record.Exception(() => Act(
														firstName,
														lastName,
														""));

			//Assert
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_too_long_firstName_should_throw_an_exception()
		{
			//Arrange
			var tooLongString = new string('x', 64);

			//Act
			var exception = Record.Exception(() => Act(
														tooLongString,
														lastName,
														userName));

			//Assert
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentOutOfRangeException));

		}

		[Fact]
		public void given_too_long_lastName_should_throw_an_exception()
		{
			//Arrange
			var tooLongString = new string('x', 64);

			//Act
			var exception = Record.Exception(() => Act(
														firstName,
														tooLongString,
														userName));
			//Assert

			exception.ShouldNotBeNull();
			exception.ShouldBeOfType<ArgumentOutOfRangeException>();
		}


		[Fact]
		public void given_too_long_userName_should_throw_an_exception()
		{
			//Arrange
			var tooLongString = new string('x', 33);

			//Act
			var exception = Record.Exception(() => Act(
														firstName,
														lastName,
														tooLongString));
			//Assert

			exception.ShouldNotBeNull();
			exception.ShouldBeOfType<ArgumentOutOfRangeException>();
		}

		[Fact]
		public void given_valid_role_to_add_should_add_role()
		{
			//Arrange
			Roles role = new Role(RoleName, RoleDescription);

			//Act
			var user = Act(
							firstName,
							lastName,
							userName);

			user.AddRole(role);

			//Assert
			user.Roles.ShouldContain(role);
		}

		[Fact]
		public void given_null_role_to_add_should_throw_an_exception()
		{
			//Arrange

			//Act
			var user = Act(
							firstName, 
							lastName,
							userName);
			var exception = Record.Exception(() => user.AddRole(null));

			//Assert
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType<ArgumentNullException>();
		}

		[Fact]
		public void given_valid_role_to_remove_should_remove_it_from_user()
		{
			//Arrange
			Roles role = new Role(RoleName, RoleDescription);

			//Act
			var user = Act(
							firstName,
							lastName,
							userName);
			user.RemoveRole(role);

			//Assert
			user.Roles.ShouldNotContain(role);
		}

		[Fact]
		public void given_invalid_role_should_throw_an_exception()
		{
			//Arrange

			//Act
			var user = Act(
							firstName,
							lastName,
							userName);
			var exception = Record.Exception(() => 
													user.RemoveRole(null));

			//Assert
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException))
		}

		#region Assert

		private string firstName => "testFirstName";
		private string lastName => "testLastName";
		private string userName => "testUserName";

		private string RoleName => "testRoleName";
		private string RoleDescription => "testRoleDescription";
		
		#endregion
	}
}
