﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace LevelUpGame.Test.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Move in a direction")]
    public partial class MoveInADirectionFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Move.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Move in a direction", "  I want to move my character. The move results in changing the current position " +
                    "of the character.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Move in a direction")]
        [NUnit.Framework.CategoryAttribute("acceptance")]
        [NUnit.Framework.TestCaseAttribute("0", "0", "NORTH", "0", "1", null)]
        [NUnit.Framework.TestCaseAttribute("0", "0", "SOUTH", "0", "0", null)]
        [NUnit.Framework.TestCaseAttribute("0", "0", "WEST", "0", "0", null)]
        [NUnit.Framework.TestCaseAttribute("0", "0", "EAST", "1", "0", null)]
        [NUnit.Framework.TestCaseAttribute("10", "0", "NORTH", "10", "1", null)]
        [NUnit.Framework.TestCaseAttribute("10", "0", "SOUTH", "10", "0", null)]
        [NUnit.Framework.TestCaseAttribute("10", "0", "WEST", "9", "0", null)]
        [NUnit.Framework.TestCaseAttribute("10", "0", "EAST", "10", "0", null)]
        [NUnit.Framework.TestCaseAttribute("10", "10", "NORTH", "10", "10", null)]
        [NUnit.Framework.TestCaseAttribute("10", "10", "SOUTH", "10", "9", null)]
        [NUnit.Framework.TestCaseAttribute("10", "10", "WEST", "9", "10", null)]
        [NUnit.Framework.TestCaseAttribute("10", "10", "EAST", "10", "10", null)]
        [NUnit.Framework.TestCaseAttribute("0", "10", "NORTH", "0", "10", null)]
        [NUnit.Framework.TestCaseAttribute("0", "10", "SOUTH", "0", "9", null)]
        [NUnit.Framework.TestCaseAttribute("0", "10", "WEST", "0", "10", null)]
        [NUnit.Framework.TestCaseAttribute("0", "10", "EAST", "1", "10", null)]
        [NUnit.Framework.TestCaseAttribute("3", "4", "NORTH", "3", "5", null)]
        [NUnit.Framework.TestCaseAttribute("3", "4", "SOUTH", "3", "3", null)]
        [NUnit.Framework.TestCaseAttribute("3", "4", "WEST", "2", "4", null)]
        [NUnit.Framework.TestCaseAttribute("3", "4", "EAST", "4", "4", null)]
        [NUnit.Framework.TestCaseAttribute("0", "7", "NORTH", "0", "8", null)]
        [NUnit.Framework.TestCaseAttribute("0", "7", "SOUTH", "0", "6", null)]
        [NUnit.Framework.TestCaseAttribute("0", "7", "WEST", "0", "7", null)]
        [NUnit.Framework.TestCaseAttribute("0", "7", "EAST", "1", "7", null)]
        [NUnit.Framework.TestCaseAttribute("10", "2", "NORTH", "10", "3", null)]
        [NUnit.Framework.TestCaseAttribute("10", "2", "SOUTH", "10", "1", null)]
        [NUnit.Framework.TestCaseAttribute("10", "2", "WEST", "9", "2", null)]
        [NUnit.Framework.TestCaseAttribute("10", "2", "EAST", "10", "2", null)]
        [NUnit.Framework.TestCaseAttribute("5", "10", "NORTH", "5", "10", null)]
        [NUnit.Framework.TestCaseAttribute("5", "10", "SOUTH", "5", "9", null)]
        [NUnit.Framework.TestCaseAttribute("5", "10", "WEST", "4", "10", null)]
        [NUnit.Framework.TestCaseAttribute("5", "10", "EAST", "6", "10", null)]
        [NUnit.Framework.TestCaseAttribute("5", "0", "NORTH", "5", "1", null)]
        [NUnit.Framework.TestCaseAttribute("5", "0", "SOUTH", "5", "0", null)]
        [NUnit.Framework.TestCaseAttribute("5", "0", "WEST", "4", "0", null)]
        [NUnit.Framework.TestCaseAttribute("5", "0", "EAST", "6", "0", null)]
        public void MoveInADirection(string startingPositionX, string starttingPositionY, string direction, string endingPositionX, string endingPositionY, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "acceptance"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("startingPositionX", startingPositionX);
            argumentsOfScenario.Add("starttingPositionY", starttingPositionY);
            argumentsOfScenario.Add("direction", direction);
            argumentsOfScenario.Add("endingPositionX", endingPositionX);
            argumentsOfScenario.Add("endingPositionY", endingPositionY);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Move in a direction", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
   testRunner.Given(string.Format("the character starts at position with XCoordinates {0}", startingPositionX), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
   testRunner.And("starts at YCoordinates <startingPositionY>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
   testRunner.And(string.Format("the player chooses to move in {0}", direction), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
   testRunner.When("the character moves", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
   testRunner.Then(string.Format("the character is not at position with XCoordinates {0}", endingPositionX), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
   testRunner.And(string.Format("YCoordinates {0}", endingPositionY), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
