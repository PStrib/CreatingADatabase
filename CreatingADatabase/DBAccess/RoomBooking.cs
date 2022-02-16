namespace CreatingADatabase.DBAccess
{
    class RoomBooking
    {
        public int office, startMonth, startYear, endMonth, endYear;

        public RoomBooking(int office, int startMonth, int startYear, int endMonth, int endYear)
        {
            this.office = office;
            this.startMonth = startMonth;
            this.startYear = startYear;
            this.endMonth = endMonth;
            this.endYear = endYear;
        }
    }
}
