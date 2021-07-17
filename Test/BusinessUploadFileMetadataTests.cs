using Business;
using Xunit;

namespace Test
{
	public class BusinessUploadFileMetadataTests
	{
		UploadFileMetadata metadata;

		public BusinessUploadFileMetadataTests()
		{
			metadata = new UploadFileMetadata(
				name: "p1.pdf",
				description: "Your Rights as a Taxpayer",
				type: "application/pdf",
				url: "https://www.irs.gov/pub/irs-pdf/p1.pdf"
				);
		}

		[Fact]
		public void ShouldCreate()
        {
			// Arrange 
			var expectedName = "p1.pdf";
			var expectedDescription = "Your Rights as a Taxpayer";
			var expectedType = "application/pdf";
			var expectedUrl = "https://www.irs.gov/pub/irs-pdf/p1.pdf";

			// Act 
			var metadata = new UploadFileMetadata(expectedName, expectedDescription, expectedType, expectedUrl);

			// Assert
			Assert.NotNull(metadata);
			Assert.Equal(expectedName, metadata.Name);
			Assert.Equal(expectedDescription, metadata.Description);
			Assert.Equal(expectedUrl, metadata.Url);
		}
	}
}
