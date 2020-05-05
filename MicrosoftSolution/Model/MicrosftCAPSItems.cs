// 	File Name : MicrosftCAPSItems.cs
// 	Auther Name : Devesh Kumar
// 	Auther EmailId : deveshkumarsep12@outlook.com
// 	Date : 05-05-2020
//
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MicrosoftCAPS.Model
{
    public class MicrosftCAPSItems
    {
        public string Cloud { get; set; }

        [Required]
        public string Token { get; set; }
    }
}
