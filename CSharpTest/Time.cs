namespace CSharpTest
{
    internal class Time
    {
        private int hour, minute, second;

        public Time()
        {
            hour = System.DateTime.Now.Hour;
            minute = System.DateTime.Now.Minute;
            second = System.DateTime.Now.Second;
        }
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public int Hour { get { return hour; } }
        public int Minute { get { return minute; } }
        public int Second { get { return second; } }

        public void IncrSecond()
        {
            second++;
            if (second >= 60)
            {
                second %= 60;
                minute++;
            }
            if (minute >= 60)
            {
                minute %= 60;
                hour++;
            }
        }
    }
}
