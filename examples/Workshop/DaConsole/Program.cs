#region Copyright (c) 2011-2021 Technosoftware GmbH. All rights reserved
//-----------------------------------------------------------------------------
// Copyright (c) 2011-2021 Technosoftware GmbH. All rights reserved
// Web: https://technosoftware.com 
//
// Purpose:
//
//
// The Software is subject to the Technosoftware GmbH Software License Agreement,
// which can be found here:
// https://technosoftware.com /documents/Technosoftware_SLA.pdf
//-----------------------------------------------------------------------------
#endregion Copyright (c) 2011-2021 Technosoftware GmbH. All rights reserved

#region Using Directives

using System;

using Technosoftware.DaAeHdaClient.Utilities;

#endregion

namespace Technosoftware.DaConsole
{
    class Program
    {
        #region Constructors, Destructor, Initialization

        /// <summary>
        /// Main Entry of the console application
        /// </summary>
        [STAThread]
        static void Main()
        {
            var myOpcSample = new OpcSample();

            ConfigUtils.EnableTrace(ConfigUtils.GetLogFileDirectory(), "Technosoftware.DaConsole.log");

            myOpcSample.Run();
        }

        #endregion
    }
}
