﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version:2.0.41202.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace PickerSample.Configuration
{


	sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
	{

		private static Settings m_Default;

		private static object gate = new object();

		public static Settings Default
		{
			get
			{
				if ((Settings.m_Default == null))
				{
					System.Threading.Monitor.Enter(Settings.gate);
					try
					{
						if ((Settings.m_Default == null))
						{
							Settings tmpObj;
							tmpObj = new Settings();
							System.Threading.Thread.MemoryBarrier();
							Settings.m_Default = tmpObj;
						}
					}
					finally
					{
						System.Threading.Monitor.Exit(Settings.gate);
					}
				}
				return Settings.m_Default;
			}
		}
	}
}
