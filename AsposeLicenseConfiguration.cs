namespace WebApi
{
	public static class AsposeLicenseConfiguration
	{

		private static readonly string LicenseFile = "Aspose.Total.lic";

		public static IServiceCollection AddAspose(this IServiceCollection services)
		{
			var asposeExcelLicense = new global::Aspose.Cells.License();
			asposeExcelLicense.SetLicense(LicenseFile);

			return services;
		}
	}
}
