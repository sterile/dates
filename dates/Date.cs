namespace dates
{
    public class Date
    {
        private int _month, // The month
            _day,           // The day
            _year;          // The year

        private const int DEFAULT_YEAR = 2019, // Default year when invalid number provided

            MIN_YEAR = 0,  // Minimum year permitted
            MIN_DAY = 1,   // Minimum date permitted 
            MIN_MONTH = 1, // Minimum month permitted

            MAX_DAY = 31,   // Maximum day permitted
            MAX_MONTH = 12; // Maximum month permitted

        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                if (value >= MIN_MONTH && value <= MAX_MONTH)
                {
                    _month = value;
                }
                else
                {
                    _month = MIN_MONTH;
                }
            }
        }

        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                if (value >= MIN_DAY && value <= MAX_DAY)
                {
                    _day = value;
                }
                else
                {
                    _day = MIN_DAY;
                }
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value >= MIN_YEAR)
                {
                    _year = value;
                }
                else
                {
                    _year = DEFAULT_YEAR;
                }
            }
        }

        public override string ToString()
        {
            string dateText = $"{_month:D2}/{_day:D2}/{_year:D4}";
            return dateText;
        }
    }
}
