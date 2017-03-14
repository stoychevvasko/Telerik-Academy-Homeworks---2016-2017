////-------------------------------------------------------------------------------------------------
//// <copyright file="StartUp.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask
{
    using System.Collections.Generic;
    using Core;

    /// <summary>
    /// Starts here.
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// Main program exe.
        /// </summary>        
        public static void Main()
        {
            var engine = Engine.Instance;
            engine.Start();

            var commandList = new List<string>();
            commandList.Add("AddEvent 2017-03-14 13:43:30 | MyTestEvent Number 1");
            commandList.Add("AddEvent 2017-03-14 14:20:00 | MyTestEvent Number 2");
            commandList.Add("AddEvent 2017-03-14 14:20:00 | MyTestEventWithLocation Number 3 | Sofia, Bulgaria");
            commandList.Add("DeleteEvents MyTestEvent Number 1");
            commandList.Add("ListEvents 2017-01-01 13:43:30 | 10");
            commandList.Add("end");
        }
    }
}