using ImageHoster.Domain.Models;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ImageHoster.Tests.Unit.BasicPhoto
{
	public class CreateBasicPhoto
	{
		private ImageHoster.Domain.Models.BasicPhoto Act(
			string title,
			string description,
			string img)
			=> new ImageHoster.Domain.Models.BasicPhoto(
														title, 
														description,
														img);

		[Fact]
		public void given_valid_data_basicPhoto_should_be_created()
		{
			//ARRANGE

			//ACT
			var basicPhoto = Act(
								Title,
								Description,
								Img);

			//Assert
			basicPhoto.ShouldNotBeNull();
			basicPhoto.Id.ShouldNotBe(Guid.Empty);

			basicPhoto.Title.ShouldBe(Title);
			basicPhoto.Description.ShouldBe(Description);
			basicPhoto.AddedDate.Day.ShouldBe(DateTime.UtcNow.Day);
			basicPhoto.AddedDate.Month.ShouldBe(DateTime.UtcNow.Month);
			basicPhoto.AddedDate.Year.ShouldBe(DateTime.UtcNow.Year);
			basicPhoto.Image.ShouldBe(Img);
			basicPhoto.Image.ShouldContain(":");
		}

		[Fact]
		public void given_null_title_should_throw_an_exception()
		{
			//ARRANGE

			//ACT
			var exception = Record.Exception(() =>
													Act(
														null,
														Description,
														Img));

			//ASSERT
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_whitespace_title_should_throw_an_exception()
		{
			//ARRANGE

			//ACT
			var exception = Record.Exception(() 
												=> Act(
														"",
														Description,
														Img));

			//ASSERT
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_null_description_should_throw_an_exception()
		{
			//ARRANGE

			//ACT
			var exception = Record.Exception(()
												=> Act(
														Title,
														null,
														Img));

			//ASSERT
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_whitespace_description_should_throw_an_exception()
		{
			//ARRANGE

			//ACT
			var exception = Record.Exception(()
												=> Act(
														Title,
														"",
														Img));

			//ASSERT
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_null_image_should_throw_an_exception()
		{
			//ARRANGE

			//ACT
			var exception = Record.Exception(()
												=> Act(
														Title,
														Description,
														null));

			//ASSERT
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void given_whitespace_image_should_throw_an_exception()
		{
			//ARRANGE

			//ACT
			var exception = Record.Exception(()
												=> Act(
														Title,
														Description,
														""));

			//ASSERT
			exception.ShouldNotBeNull();
			exception.ShouldBeOfType(typeof(ArgumentNullException));
		}

		#region Assert

		private string Title => "BasicPhotoTitle";
		private string Description => "BasicPhotoDescription";
		private string Img => "c:/BasicPhotoImgTest/";

		#endregion
	}
}
