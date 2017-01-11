////-----------------------------------------------------------------------
//// <copyright file="Worker.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    /// <summary>
    /// Represents a worker.
    /// </summary>
    public class Worker : Human
    {
        /// <summary>
        /// Holds a default value for the weekly salary of a worker.
        /// </summary>
        private const double DefaultWeeklySalary = 0d;

        /// <summary>
        /// Holds the default value for the daily hours worked by a worker.
        /// </summary>
        private const double DefaultWorkHoursPerDay = 8.0d;

        /// <summary>
        /// Holds the default worker name value.
        /// </summary>
        private const string DefaultWorkerName = "Default_Worker_Name";

        /// <summary>
        /// Holds the default worker surname value.
        /// </summary>
        private const string DefaultWorkerSurname = "Default_Worker_Surname";

        /// <summary>
        /// Initializes a new instance of the <see cref="Worker"/> class.
        /// </summary>
        /// <param name="firstName">Worker's first name.</param>
        /// <param name="lastName">Worker's surname.</param>
        /// <param name="weeklySalary">Worker's weekly salary.</param>
        /// <param name="workHoursPerDay">Worker's hours worked per day.</param>
        public Worker(string firstName, string lastName, double weeklySalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeeklySalary = weeklySalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Worker"/> class.
        /// </summary>
        public Worker()
            : this(Worker.DefaultWorkerName, Worker.DefaultWorkerSurname, Worker.DefaultWeeklySalary, Worker.DefaultWorkHoursPerDay)
        {
        }

        /// <summary>
        /// Gets or sets a worker's weekly salary.
        /// </summary>
        public double WeeklySalary
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a worker's number of hours per day.
        /// </summary>
        public double WorkHoursPerDay
        {
            get;
            set;
        }

        /// <summary>
        /// Calculates the per-hour salary of a worker.
        /// </summary>
        /// <returns>The hourly salary as a <see cref="double"/> value.</returns>
        public double MoneyPerHour()
        {
            return this.WeeklySalary / 5.0d / this.WorkHoursPerDay;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> value.</returns>
        public override string ToString()
        {
            return string.Format(
                "{0}\n   Weekly salary: {1:C2} Work hours per day: {2} Money per hour: {3:C2}\n",
                base.ToString(),
                this.WeeklySalary,
                this.WorkHoursPerDay,
                this.MoneyPerHour());
        }
    }
}
