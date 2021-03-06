﻿using System;
using Xamarin.Forms.Labs.Services;
using Xamarin.Forms.Labs.Services.Media;
using Xamarin.Forms.Labs.Services.Geolocation;

namespace Xamarin.Forms.Labs
{
	/// <summary>
	/// Abstracted device interface.
	/// </summary>
	public interface IDevice
	{
        /// <summary>
        /// Gets Unique Id for the device.
        /// </summary>
        string Id { get; }

		/// <summary>
		/// Gets the display information for the device.
		/// </summary>
		IDisplay Display { get; }

		/// <summary>
		/// Gets the phone service for this device.
		/// </summary>
		/// <value>Phone service instance if available, otherwise null.</value>
		IPhoneService PhoneService { get; }

		/// <summary>
		/// Gets the battery for the device.
		/// </summary>
		IBattery Battery { get; }

		/// <summary>
		/// Gets the accelerometer.
		/// </summary>
        /// <value>The accelerometer instance if available, otherwise null.</value>
		IAccelerometer Accelerometer { get; }

        /// <summary>
        /// Gets the gyroscope.
        /// </summary>
        /// <value>The gyroscope instance if available, otherwise null.</value>
        IGyroscope Gyroscope { get; }

		/// <summary>
		/// Gets the picture chooser.
		/// </summary>
		/// <value>The picture chooser.</value>
		IMediaPicker MediaPicker { get; }

        /// <summary>
        /// Gets the network service.
        /// </summary>
        /// <value>The network service.</value>
        INetwork Network { get; }

		/// <summary>
		/// Gets the name of the device.
		/// </summary>
		/// <value>The name of the device.</value>
		string Name { get; }

		/// <summary>
		/// Gets the firmware version.
		/// </summary>
		string FirmwareVersion { get; }

		/// <summary>
		/// Gets the hardware version.
		/// </summary>
		string HardwareVersion { get; }

		/// <summary>
		/// Gets the manufacturer.
		/// </summary>
		string Manufacturer { get; }
	}
}

