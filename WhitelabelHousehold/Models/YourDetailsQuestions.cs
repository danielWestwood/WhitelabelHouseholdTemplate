using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //added to allow validation i.e. [Required]
using System.ComponentModel.DataAnnotations.Schema; //Added for EF

namespace WhitelabelHousehold.Models
{
    public class YourDetailsQuestions
    {
        [Required]
        [Display(Name = "House number of name")]
        public string HouseNumberOrName { get; set; }

        [Required(ErrorMessage = "Please search for your address")]
        [StringLength(7)]
        [Display(Name = "Postcode")]
        public string Postcode { get; set; }

        [Required]
        [Range(1, 6)]
        [Display(Name = "Number of bedrooms")]
        public int Bedrooms { get; set; }

        [Display(Name = "What type of cover would you like")]
        public string TypeOfCover { get; set; } //Does not include required because this will be a RadioButtonFor and therefore, has a default value

        [Required(ErrorMessage = "Please select a year of build")]
        [Display(Name = "Year of build")]
        public string YearOfBuild { get; set; }

        [Required(ErrorMessage = "Please select type of property")]
        [Display(Name = "Type of property")]
        public string TypeOfProperty { get; set; }

        [Required(ErrorMessage = "Please select how many children under 18 live at the property")]
        [Display(Name = "How many children under 18 live at the property")]
        public string Children { get; set; }

        [Required(ErrorMessage = "Please enter valid date")]
        [DataType(DataType.Date)]
        [Display(Name = "Cover start date")]
        public DateTime CoverStartDate { get; set; }

        //Initial Holder Details

        [Required(ErrorMessage = "Please select your title")]
        [Display(Name = "What's your title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "please enter your surname")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter a valid date")] //look at how to set a max integer
        public int Day { get; set; }

        [Required(ErrorMessage = "Please enter a valid date")] //look at how to set a max integer
        public int Month { get; set; }

        [Required(ErrorMessage = "Please enter a valid date")] //look at how to set a max integer
        public int Year { get; set; }

        [Display(Name = "Select to add joint policy holder")] //Initiate JQuery upon "True"/"Checked"
        public bool JointPolicy { get; set; }

        //Joint Policy Holder Details

        [Display(Name = "What's their title")]
        public string TheirTitle { get; set; }

        [Display(Name = "What's their first name")]
        public string TheirFirstName { get; set; }

        [Display(Name = "What's their surname")]
        public string TheirSurname { get; set; }

        //[Required(ErrorMessage = "Please enter a valid date for the Joint")] //look at how to set a max integer
        [Display(Name = "What's thier day?")]
        public int TheirDay { get; set; }

        [Display(Name = "What's their month?")]
        public int TheirMonth { get; set; }

        [Display(Name = "What's their month?")]
        public int TheirYear { get; set; }

        //End

        [Required(ErrorMessage = "Please enter a valid e-mail address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail address (used to send you a copy of your quotation)")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid telephone number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Main telephone number")]
        public int TelephoneNumber { get; set; }

        [Display(Name = "Mobile number (if different)")]
        [DataType(DataType.PhoneNumber)]
        public int MobileNumber { get; set; }

        [Required(ErrorMessage = "Please select")]
        [Display(Name = "How many years have you held Buildings Insurance for?")]
        [Range(0, 4)]
        public int BuildingsInsurance { get; set; }

        [Required(ErrorMessage = "Please select")]
        [Display(Name = "How many years have you held Contents Insurance for?")]
        [Range(0, 4)]
        public int ContentsInsurance { get; set; }

        [Display(Name = "How many claims or losses have you or anyone living with you, suffered at or away from home in the last 4 years?")]
        [Range(0, 3)]
        public int ClaimsOrLosses { get; set; } //Not included in the current view

        //Hidden Claims - Claim 1 - Look into IEnumerable to make a list (DRY Principles)

        [Required(ErrorMessage = "Please enter a valid date for the Joint")] //look at how to set a max integer
        public int ClaimDay { get; set; }

        [Required(ErrorMessage = "Please enter a valid date")] //look at how to set a max integer
        public int ClaimMonth { get; set; }

        [Required(ErrorMessage = "Please enter a valid date")] //look at how to set a max integer
        public int ClaimYear { get; set; }

        //---------------------------------------------------------------------------------------

        //public virtual ICollection<Quotes> Quotes { get; set; } - Requires DB
    }
}