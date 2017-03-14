////-------------------------------------------------------------------------------------------------
//// <copyright file="StartUp.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask
{
    using System;
    using Core;

    /// <summary>
    /// Contains main program executable.
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// Main program executable.
        /// </summary>        
        public static void Main()
        {
            //// Singleton design pattern
            //// Ensures that there is only 
            //// one instance of Engine in existance
            var engine = Engine.Instance;
            engine.Start();

            // Some commands to test the code below:
            // AddEvent 2017-03-14 13:43:30 | MyTestEvent Number 1
            // AddEvent 2017-03-14 14:20:00 | MyTestEvent Number 2
            // AddEvent 2017-03-14 14:20:00 | MyTestEventWithLocation Number 3 | Sofia, Bulgaria
            // DeleteEvents MyTestEvent Number 1
            // ListEvents 2017-01-01 13:43:30 | 10
            // end            
        }
    }
}