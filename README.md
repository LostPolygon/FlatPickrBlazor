# flatpickr Blazor

# !only a development version! (use with caution)

## Usage

### MyFlatpickr.razor
	<div>
		<Flatpickr Hidden="true" @ref="_datepicker" Options="@calendarOpts" OnChange="@OnChangeDate" />
		<Flatpickr Hidden="true" Options="@monthPickerOpts" PluginOptions="@monthPluginOptions" />
	</div>

	@code{
		private Flatpickr _datepicker;

		private FlatpickrOptions calendarOpts = new FlatpickrOptions{
			inline = true,
			weekNumbers = true,
			maxDate = DateTimeOffset.UtcNow
		};

		private FlatpickrOptions monthPickerOpts = new FlatpickrOptions{
			inline = true
		};

		// these are already default values, so new FlatpickrPluginOptions() would fullfill everything, if you want default values
		private FlatpickrPluginOptions monthPluginOptions = new FlatpickrPluginOptions {
		    shortHand = false, 
            dateFormat = "F Y",
            altFormat = "F Y",
            theme = "light"
		};

		private void OnChangeDate(List<DateTimeOffset> dateTimes) {
			foreach(var dateTime in dateTimes) {
				Console.WriteLine(dateTime.ToString());
			}
			_datepicker.SetDate(DateTimeOffset.Now);
		}
	}

### _Host.cshtml

you have to include at a minimum these to your _Host.cshtml

	<link href="_content/FlatpickrBlazor/flatpickr.min.css" rel="stylesheet" />
	<script src="_content/FlatpickrBlazor/flatpickr.min.js"></script>
	<script src="_content/FlatpickrBlazor/flatpickr.blazor.js"></script>


to add a locale (specify in your FlatpickrOptions variable) add the following script:

	<script src="_content/FlatpickrBlazor/l10n/de.js"></script>

and change the "de.js" with your choosed language

to add the plugins, you have to include the script and style files. e.g. for the month select plugin: 

	<link href="_content/FlatpickrBlazor/plugins/monthSelect/style.css" rel="stylesheet" />
	<script src="_content/FlatpickrBlazor/plugins/monthSelect/index.js"></script>
