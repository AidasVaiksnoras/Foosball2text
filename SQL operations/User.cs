using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SQL_operations
{
    public struct TimePassed
    {
        int years, months, days, hours, minutes, seconds;

        public TimePassed(string timePassed) //If data from SQL passed as parameter
        {
            if (!WriteOperations.CorrectDateTimeFormat(timePassed))
                throw new FormatException(timePassed);
            years = int.Parse(timePassed.Substring(0, 4));
            months = int.Parse(timePassed.Substring(5, 2));
            days = int.Parse(timePassed.Substring(8, 2));
            hours = int.Parse(timePassed.Substring(11, 2));
            minutes = int.Parse(timePassed.Substring(14, 2));
            seconds = int.Parse(timePassed.Substring(17, 2));
        }

        public TimePassed(int days, int hours, int minutes, int seconds) //If data from logic passed as parameter
        {
            this.years = 0;
            this.months = 0;
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public static TimePassed operator + (TimePassed timePassed1, TimePassed timePassed2)
        {
            TimePassed result = new TimePassed();
            result.years = timePassed1.years + timePassed2.years;
            result.months = timePassed1.months + timePassed2.months;
            result.days = timePassed1.days + timePassed2.days;
            result.hours = timePassed1.hours + timePassed2.hours;
            result.minutes = timePassed1.minutes + timePassed2.minutes;
            result.seconds = timePassed1.seconds + timePassed2.seconds;

            if (result.seconds > 60)
            {
                result.minutes++;
                result.seconds -= 60;
            }
            if (result.minutes > 60)
            {
                result.hours++;
                result.minutes -= 60;
            }
            if (result.hours > 24)
            {
                result.days++;
                result.hours -= 24;
            }
            if (result.days > 30)
            {
                result.months++;
                result.days -= 30;
            }
            if (result.months > 12)
            {
                result.years++;
                result.months -= 12;
            }

            return result;
        }

        public string ConvertedTo8601()
        {
            return years.ToString("D4") + "-" + months.ToString("D2") + "-" + days.ToString("D2") + "T" + hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2") + "Z";
        }
    }

    public class User : IEquatable<User>
    {
        public string UserName { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public double MaxSpeed { get; set; }
        public int TotalGoals { get; set; }
        public TimePassed AllTimePlayed { get; set; }
        public string AllTimePlayedISO8601 { get => AllTimePlayed.ConvertedTo8601(); }
        public int RankPoints { get; set; }

        public User()
        {
        }

        public User(string name) //Used in case of new profile creation
        {
            UserName = name;
        }

        public User(string userName, int gamesPlayed, int gamesWon, double maxSpeed, int totalGoals, string allTimePlayed, int rankPoints) //Got data from SQL constructor
        {
            UserName = userName;
            GamesPlayed = gamesPlayed;
            GamesWon = gamesWon;
            MaxSpeed = maxSpeed;
            TotalGoals = totalGoals;
            try
            {
                AllTimePlayed = new TimePassed(allTimePlayed);
            }
            catch (FormatException e)
            {
                new ExceptionForm(e.ToString()).Show();
            }
            RankPoints = rankPoints;
        }

        public void UpdateData(bool addGamePlayed, bool addGameWon, double gamesMaxSpeed, int addScore, TimeSpan gameTime , int rankChange)
        {
            GamesPlayed++;
            if (addGameWon)
                GamesWon++;
            if (gamesMaxSpeed > MaxSpeed)
                MaxSpeed = gamesMaxSpeed;
            TotalGoals += addScore;
            TimePassed timePassed = new TimePassed(gameTime.Days, gameTime.Hours, gameTime.Minutes, gameTime.Seconds);
            AllTimePlayed += timePassed;
            RankPoints += rankChange;
        }

        public bool Equals(User other)
        {
            return (UserName == other.UserName &&
                GamesPlayed == other.GamesPlayed &&
                GamesWon == other.GamesWon &&
                MaxSpeed == other.MaxSpeed &&
                TotalGoals == other.TotalGoals &&
                AllTimePlayedISO8601 == other.AllTimePlayedISO8601 &&
                RankPoints == other.RankPoints);
        }
    }
}
