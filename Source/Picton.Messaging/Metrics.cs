﻿using App.Metrics;
using App.Metrics.Counter;
using App.Metrics.Gauge;
using App.Metrics.Timer;

namespace Picton.Messaging
{
	internal static class Metrics
	{
		/// <summary>
		/// Gets the counter indicating the number of messages processed by the message pump
		/// </summary>
		public static CounterOptions MessagesProcessedCounter => new CounterOptions
		{
			Context = "Picton",
			Name = "MessagesProcessedCount",
			MeasurementUnit = Unit.Items
		};

		/// <summary>
		/// Gets the counter indicating the time it takes to process a message
		/// </summary>
		public static TimerOptions MessageProcessingTimer => new TimerOptions
		{
			Context = "Picton",
			Name = "MessageProcessingTime"
		};

		public static TimerOptions MessageFetchingTimer => new TimerOptions
		{
			Context = "Picton",
			Name = "MessageFetchingTime"
		};

		/// <summary>
		/// Gets the counter indicating the number of times we attempted to fetch messages from the Azure queue but the queue was empty
		/// </summary>
		public static CounterOptions QueueEmptyCounter => new CounterOptions
		{
			Context = "Picton",
			Name = "QueueEmptyCount"
		};

		/// <summary>
		/// Gets the guage indicating the number of messages waiting in the queue over time
		/// </summary>
		public static GaugeOptions QueuedMessagesGauge => new GaugeOptions
		{
			Context = "Picton",
			Name = "QueuedMessages",
			MeasurementUnit = Unit.Items
		};
	}
}
