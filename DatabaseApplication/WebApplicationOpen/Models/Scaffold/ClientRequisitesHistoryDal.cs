using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationOpen.Models.Scaffold
{
	[Table("ClientRequisitesHistory")]
	public class ClientRequisitesHistoryDal
	{
		[Key]
		public long ClientRequisitesHistoryId { get; set; }
		public long ClientId { get; set; }
		public DateTime Date { get; set; }
		public string Unp { get; set; }
		public string UserName { get; set; }
		public string ChiefName { get; set; }
		public string RepresenterName { get; set; }
		public string PassportNumber { get; set; }
		public string PassportIssue { get; set; }
		public string Account { get; set; }
		public string BankName { get; set; }
		public string BankCode { get; set; }
		public string Payer { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string Email { get; set; }
		public string AccountEmail { get; set; }
		public int? CountryId { get; set; }
		public int? PrimaryAddressCountryId { get; set; }
		public string PrimaryAddressZipZode { get; set; }
		public string PrimaryAddressStreet { get; set; }
		public string PrimaryAddressCity { get; set; }
		public string PrimaryAddressDistrict { get; set; }
		public string PrimaryAddressBuilding { get; set; }
		public string PrimaryAddressRoom { get; set; }
		public int? SecondaryAddressCountryId { get; set; }
		public string SecondaryAddressZipZode { get; set; }
		public string SecondaryAddressStreet { get; set; }
		public string SecondaryAddressCity { get; set; }
		public string SecondaryAddressDistrict { get; set; }
		public string SecondaryAddressBuilding { get; set; }
		public string SecondaryAddressRoom { get; set; }
		public string EnterpriseTitle { get; set; }
		public string PassportSeries { get; set; }
		public string PassportIssueDate { get; set; }
		public string PassportIdentificationNumber { get; set; }
		public string EgrNumber { get; set; }
		public string EgrRegistrar { get; set; }
		public string EgrDecisionNumber { get; set; }
		public string EgrDecisionDate { get; set; }

		public virtual ClientDal Client { get; set; }

		[NotMapped]
		public virtual CountryDal Country { get; set; }
		[NotMapped]
		public virtual CountryDal PrimaryAddressCountry { get; set; }
		[NotMapped]
		public virtual CountryDal SecondaryAddressCountry { get; set; }
	}
}
