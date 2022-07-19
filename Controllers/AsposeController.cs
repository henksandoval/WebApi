namespace WebApi.Controllers
{
	using Aspose.Cells;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	[Route("[controller]")]
	public class AsposeController :ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			try
			{
				Workbook workBook = new Workbook();
				var sheet = workBook.Worksheets[0];
				sheet.Cells[0, 0].Value = "Using Aspose Cells on linux with VS Code.";
				sheet.AutoFitRow(0, 0, 10);
				workBook.Save("test.xlsx");

				return Ok();
			}
			catch (Exception ex)
			{
				return Problem(ex.Message, ex.StackTrace);
			}
		}
	}
}
