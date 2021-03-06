﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Testes
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Testar funcoes de validacao de campos")]
    public partial class TestarFuncoesDeValidacaoDeCamposFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ValidarCampos.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Testar funcoes de validacao de campos", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Campo valido")]
        [NUnit.Framework.TestCaseAttribute("\'nome\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'nascimento\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'email\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'telefone\'", new string[0])]
        public virtual void CampoValido(string campo, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Campo valido", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given(string.Format("eu recebi um {0} com valor valido", campo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.When(string.Format("eu chamar o validador do {0}", campo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.Then(string.Format("eu devo receber um retorno True para o {0}", campo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Campo invalido")]
        [NUnit.Framework.TestCaseAttribute("\'nome\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'nascimento\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'email\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'telefone\'", new string[0])]
        public virtual void CampoInvalido(string campo, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Campo invalido", exampleTags);
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given(string.Format("eu recebi um {0} com valor invalido", campo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When(string.Format("eu chamar o validador do {0}", campo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then(string.Format("eu devo receber um retorno False para o {0}", campo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
