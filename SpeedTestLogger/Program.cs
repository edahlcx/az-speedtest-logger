﻿using System;
using System.Linq;
using System.Globalization;
using SpeedTest;
using SpeedTestLogger.Models;

namespace SpeedTestLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SpeedTestLogger");

            var config = new LoggerConfiguration();
            var runner = new SpeedTestRunner(config.LoggerLocation);

            var testData = runner.RunSpeedTests();
            var results = new TestResult
            {
                SessionId = new Guid(),
                User = config.UserId,
                Device = config.LoggerId,
                Timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                Data = testData
            };
        }
    }
}