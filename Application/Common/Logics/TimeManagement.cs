using System;

namespace Application.Common.Logics
{
    /// <summary>
    /// This *(Time Management) class contains only related time scheduling for entire application.
    /// This class is sealed so please do not inherited any other class.
    /// This class is *(Single Ton) class.
    /// </summary>
    public sealed class TimeManagement
    {
        #region SingleTon
        private static TimeManagement instance = null;
        public static TimeManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TimeManagement();
                }

                return instance;
            }
        }

        private TimeManagement()
        {
        } 
        #endregion

        /// <summary>
        /// this method is return date time now *(Microsoft system property).
        /// Use this method when the new driver and rider enroll first time.
        /// </summary>
        /// <returns></returns>
        public DateTime DateTimeNow()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// this method is return date time now *(Microsoft system property).
        /// Use this method when the driver and rider modified existing value respectively.
        /// </summary>
        /// <returns></returns>
        public DateTime LastModified()
        {
            return DateTime.Now;
        }
    }
}