﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code


#pragma warning disable

namespace Habitat.Accounts.Specflow
{
  using TechTalk.SpecFlow;

  [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
  [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public partial class PageAfterLoginFeature : Xunit.IUseFixture<PageAfterLoginFeature.FixtureData>, System.IDisposable
  {
    private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "Page after login.feature"
#line hidden

    public PageAfterLoginFeature()
    {
      this.TestInitialize();
    }

    public static void FeatureSetup()
    {
      testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
      var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Page after login", "", ProgrammingLanguage.CSharp, ((string[])(null)));
      testRunner.OnFeatureStart(featureInfo);
    }

    public static void FeatureTearDown()
    {
      testRunner.OnFeatureEnd();
      testRunner = null;
    }

    public virtual void TestInitialize()
    {
    }

    public virtual void ScenarioTearDown()
    {
      testRunner.OnScenarioEnd();
    }

    public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
    {
      testRunner.OnScenarioStart(scenarioInfo);
    }

    public virtual void ScenarioCleanup()
    {
      testRunner.CollectScenarioErrors();
    }

    public virtual void SetFixture(PageAfterLoginFeature.FixtureData fixtureData)
    {
    }

    void System.IDisposable.Dispose()
    {
      this.ScenarioTearDown();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
    [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC1_Define custom page")]
    public virtual void Accounts_PageAfterLogin_UC1_DefineCustomPage()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC1_Define custom page", new string[]
      {
        "NeedImplementation"
      });
#line 5
      this.ScenarioSetup(scenarioInfo);
#line hidden
      var table1 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "Confirm password"
      });
      table1.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k",
        "k"
      });
#line 6
      testRunner.Given("User is registered in Habitat", ((string)(null)), table1, "Given ");
#line 9
      testRunner.And("Content Editor is opened by Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
      testRunner.And("Sitecore/Content/Habitat item is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
      testRunner.When("User inputs </sitecore/content/Habitat/Home/Contact Us> page in to the AfterLogin" +
                      "Page: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
      testRunner.And("User presses Save button on the Content Editor ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
      testRunner.And("Actor opens Habitat website on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table2 = new TechTalk.SpecFlow.Table(new string[]
      {
        "E-mail",
        "Password"
      });
      table2.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k"
      });
#line 14
      testRunner.And("Actor enteres following data into fields", ((string)(null)), table2, "And ");
#line 17
      testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
      testRunner.Then("Page URL ends on /Contact-Us", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
      testRunner.And("Contact-Us title presents on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
    [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC2_Define custom page_defined page does not exists")]
    public virtual void Accounts_PageAfterLogin_UC2_DefineCustomPage_DefinedPageDoesNotExists()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC2_Define custom page_defined page does not exists", new string[]
      {
        "NeedImplementation"
      });
#line 24
      this.ScenarioSetup(scenarioInfo);
#line hidden
      var table3 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "Confirm password"
      });
      table3.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k",
        "k"
      });
#line 25
      testRunner.Given("User is registered in Habitat", ((string)(null)), table3, "Given ");
#line 28
      testRunner.And("Content Editor is opened by Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
      testRunner.And("Sitecore/Content/Habitat item is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
      testRunner.When("User inputs </sitecore/content/Habitat/Home/KOV> page in to the AfterLoginPage: f" +
                      "ield", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
      testRunner.And("User presses Save button on the Content Editor ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
      testRunner.And("User clicks Save button on Message dialog popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
      testRunner.And("Actor opens Habitat website on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table4 = new TechTalk.SpecFlow.Table(new string[]
      {
        "E-mail",
        "Password"
      });
      table4.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k"
      });
#line 34
      testRunner.And("Actor enteres following data into fields", ((string)(null)), table4, "And ");
#line 37
      testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
      testRunner.Then("Page URL ends on /en", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
    [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC3_Define custom page_empty value")]
    public virtual void Accounts_PageAfterLogin_UC3_DefineCustomPage_EmptyValue()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC3_Define custom page_empty value", new string[]
      {
        "NeedImplementation"
      });
#line 42
      this.ScenarioSetup(scenarioInfo);
#line hidden
      var table5 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "Confirm password"
      });
      table5.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k",
        "k"
      });
#line 43
      testRunner.Given("User is registered in Habitat", ((string)(null)), table5, "Given ");
#line 46
      testRunner.And("Content Editor is opened by Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
      testRunner.And("Sitecore/Content/Habitat item is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
      testRunner.When("User inputs <empty> page in to the AfterLoginPage: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
      testRunner.And("User presses Save button on the Content Editor ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
      testRunner.And("Actor opens Habitat website on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table6 = new TechTalk.SpecFlow.Table(new string[]
      {
        "E-mail",
        "Password"
      });
      table6.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k"
      });
#line 51
      testRunner.And("Actor enteres following data into fields", ((string)(null)), table6, "And ");
#line 54
      testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
      testRunner.Then("Page URL ends on /en", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
    [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC4_After login page for new registered user")]
    public virtual void Accounts_PageAfterLogin_UC4_AfterLoginPageForNewRegisteredUser()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC4_After login page for new registered user", new string[]
      {
        "NeedImplementation"
      });
#line 59
      this.ScenarioSetup(scenarioInfo);
#line 60
      testRunner.Given("Content Editor is opened by Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
      testRunner.And("Sitecore/Content/Habitat item is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
      testRunner.When("User inputs </sitecore/content/Habitat/Home/Contact Us> page in to the AfterLogin" +
                      "Page: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
      testRunner.And("User presses Save button on the Content Editor ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
      testRunner.And("User opens Habitat website on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table7 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "ConfirmPassword"
      });
      table7.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k",
        "k"
      });
#line 65
      testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table7, "When ");
#line 68
      testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
      testRunner.Then("Page URL ends on /Contact-Us", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
      testRunner.And("Contact-Us title presents on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
    [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC5_After login behavior for login pop up")]
    public virtual void Accounts_PageAfterLogin_UC5_AfterLoginBehaviorForLoginPopUp()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC5_After login behavior for login pop up", new string[]
      {
        "NeedImplementation"
      });
#line 74
      this.ScenarioSetup(scenarioInfo);
#line hidden
      var table8 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "Confirm password"
      });
      table8.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k",
        "k"
      });
#line 75
      testRunner.Given("User is registered in Habitat", ((string)(null)), table8, "Given ");
#line 78
      testRunner.And("Content Editor is opened by Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
      testRunner.And("Sitecore/Content/Habitat item is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
      testRunner.When("User inputs </sitecore/content/Habitat/Home/Contact Us> page in to the AfterLogin" +
                      "Page: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
      testRunner.And("User presses Save button on the Content Editor ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
      testRunner.And("Actor opens Habitat website on Main page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
      testRunner.And("Actor moves cursor over User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
      testRunner.And("Actor clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table9 = new TechTalk.SpecFlow.Table(new string[]
      {
        "E-mail",
        "Password"
      });
      table9.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k"
      });
#line 85
      testRunner.And("Actor enteres following data into fields", ((string)(null)), table9, "And ");
#line 88
      testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
      testRunner.Then("User remains on the Main page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
      this.ScenarioCleanup();
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class FixtureData : System.IDisposable
    {
      public FixtureData()
      {
        FeatureSetup();
      }

      void System.IDisposable.Dispose()
      {
        FeatureTearDown();
      }
    }
  }
}

#pragma warning restore

#endregion