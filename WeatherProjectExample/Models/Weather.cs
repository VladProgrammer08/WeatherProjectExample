using System.ComponentModel.DataAnnotations;

namespace WeatherProjectExample.Models
{
	public class Weather
	{
		[Required(ErrorMessage = "City Name is required")]
		public string City { get; set; }

	}
}
