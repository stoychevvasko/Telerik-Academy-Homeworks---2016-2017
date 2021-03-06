﻿using System.Collections.Generic;

namespace Problem_12
{
    /// <summary>
    /// Represents mobile phone device.
    /// </summary>
    public class GSM
        : Problem_11.GSM
    {
        // fields
        /// <summary>
        /// Holds a <see cref="List{Call}"/>, a list of all <see cref="Call"/> instances done by a mobile device of the <see cref="GSM"/> class.
        /// </summary>
        new protected List<Call> callHistory;

        // constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="model">Represents device model for <see cref="GSM"/> objects.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="GSM"/> objects.</param>
        /// <param name="price">Represents price details for <see cref="GSM"/> objects.</param>
        /// <param name="owner">Represents owner details for <see cref="GSM"/> objects.</param>
        /// <param name="battery">Represents <see cref="Battery"/> component for <see cref="GSM"/> objects.</param>
        /// <param name="display">Represents <see cref="Display"/> component for <see cref="GSM"/> objects.</param>
        /// <param name="calls">Represents a <see cref="List{Call}"/>, a list of all <see cref="Call"/> instances done by a mobile device of the <see cref="GSM"/> class.</param>
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display, List<Call> calls)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = calls;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="model">Represents device model for <see cref="GSM"/> objects.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="GSM"/> objects.</param>
        /// <param name="price">Represents price details for <see cref="GSM"/> objects.</param>
        /// <param name="owner">Represents owner details for <see cref="GSM"/> objects.</param>
        /// <param name="battery">Represents <see cref="Battery"/> component for <see cref="GSM"/> objects.</param>
        /// <param name="display">Represents <see cref="Display"/> component for <see cref="GSM"/> objects.</param>
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery, display, new List<Call>())
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="model">Represents device model for <see cref="GSM"/> objects.</param>
        /// <param name="manufacturer">Represents manufacturer information for <see cref="GSM"/> objects.</param>
        public GSM(string model, string manufacturer)
               : this(model, manufacturer, null, null, new Battery(), new Display())
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        public GSM()
            : this(DEFAULT_MODEL, DEFAULT_MANUFACTURER)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GSM"/> class.
        /// </summary>
        /// <param name="gsm">Represents an existing <see cref="GSM"/> component.</param>
        public GSM(GSM gsm)
            : this(gsm.Model, gsm.Manufacturer, gsm.Price, gsm.Owner,
                  new Battery(gsm.Battery.Model, gsm.Battery.HoursIdle, gsm.Battery.HoursTalked, gsm.Battery.BatteryType),
                  new Display(gsm.Display.Size, gsm.Display.NumberOfColors))
        {
        }

        // properties
        /// <summary>
        /// Represents a <see cref="List{Call}"/>, a list of all <see cref="Call"/> instances done by a mobile device of the <see cref="GSM"/> class.
        /// </summary>
        new public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        // methods
        /// <summary>
        /// Adds a <see cref="Call"/> to the end of the <see cref="CallHistory"/>.
        /// </summary>
        /// <param name="call">Represents a telephone conversation.</param>
        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        /// <summary>
        /// Removes the first occurrence of a specific <see cref="Call"/> from the <see cref="CallHistory"/>.
        /// </summary>
        /// <param name="call">Represents a telephone conversation.</param>
        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        /// <summary>
        /// Removes all elements from the <see cref="GSM.CallHistory"/>.
        /// </summary>
        new public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        /// <summary>
        /// Calculates the total <see cref="Call"/> cost of a <see cref="GSM"/> based on <see cref="GSM.CallHistory"/>.
        /// </summary>
        /// <param name="pricePerMinute">Represents charge rate per minute of <see cref="Call"/> as <see cref="decimal"/>.</param>
        /// <returns>Returns total call costs as <see cref="decimal"/>.</returns>
        new public decimal CalculateTotalCallCosts(decimal pricePerMinute)
        {
            if (this.CallHistory == null || this.CallHistory.Count == 0)
            {
                return 0M;
            }
            else
            {
                decimal result = 0;
                foreach (var item in this.CallHistory)
                {
                    result += (item.Duration / 60M * pricePerMinute);
                }
                return result;
            }
        }
    }
}
