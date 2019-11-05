﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlatpickrBlazor
{
    public class FlatpickrOptions
    {
        public string dateFormat { get; set; } = "Y-m-d";
        public bool inline { get; set; } = false;
        public bool noCalendar { get; set; } = false;
        public bool enableTime { get; set; } = false;
        public bool time_24hr { get; set; } = false;
        public bool weekNumbers { get; set; } = false;
        public string locale { get; set; } = "de";
        public DateTimeOffset? minDate { get; set; } = null;
        public DateTimeOffset? maxDate { get; set; } = null;
        public int minuteIncrement { get; set; } = 5;
        public List<string> defaultDate { get; set; } = null;
    }
}
