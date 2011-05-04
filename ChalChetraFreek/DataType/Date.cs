using System;

namespace ChalChetraFreek.DataType
{
    public class Date
    {
        private sbyte day;
        private sbyte month;
        private short year;

        public short WatsYourYear
        {
            get { return year; }
        }

        public sbyte WatsYourMonth
        {
            get { return month; }
        }

        public sbyte WatsYourDay
        {
            get { return day; }
        }

        public string WatsIt
        {
            get { return ToString(); }
        }

        public Date(string date)
        {
            SetDateFeilds(date);
        }

        public override string ToString()
        {
            return day.ToString("#00") + "/" + month.ToString("#00") + "/" + year.ToString("#0000");
        }

        private void SetDateFeilds(string date)
        {
            var datetime = DateTime.Parse(date);
            day = (sbyte)datetime.Day;
            month = (sbyte)datetime.Month;
            year = (short)datetime.Year;
        }
    }
}