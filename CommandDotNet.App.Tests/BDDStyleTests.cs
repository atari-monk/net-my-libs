//after nuget updates doesnt work

// using CommandDotNet.TestTools.Scenarios;
// using Xunit;

// namespace CommandDotNet.App.Tests;

// public class BDDStyleTests
// {
//   [Fact]
//   public void Given2Numbers_Should_OutputSum() =>
//     Program.AppRunner.Verify(new Scenario
//     {
//       When = { Args = "Add 40 20" },
//       Then = { Output = "60" }
//     });

//   [Fact]
//   public void GivenANonNumber_Should_OutputValidationError() =>
//     Program.AppRunner.Verify(new Scenario
//     {
//       When = { Args = "Add a 20" }
//       ,
//       Then =
//       {
//         ExitCode = 2,
// 				Output = "'a' is not a valid Number"
//       }
//     });
// }