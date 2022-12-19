using Framework.Models;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Framework.Pages
{
    public partial class GoogleCloudPricingCalculatorPage : AbstractPage
    {
        public GoogleCloudPricingCalculatorPage(IWebDriver driver) : base(driver) { }

        public void EnterCredentialsOfComputeEngine(ComputeEngine computeEngine)
        {
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//devsite-iframe/child::iframe")));
            Driver.SwitchTo().Frame("myFrame");

            InstanceField.Click();
            InstanceField.SendKeys(computeEngine.NumberOfInstances);

            OperatingSystemOrSoftwareSelectIcon.Click();
            ChooseOption(OperatingSystemOrSoftwareOptions, computeEngine.OperatingSystemOrSoftwareText);

            ProvisionModelSelectIcon.Click();
            ChooseOption(ProvisionModelOptions, computeEngine.ProvisionModelText);

            MachineTypeSelectIcon.Click();
            ChooseOption(MachineTypeOptions, computeEngine.MachineTypeText);

            AddGpusCheckBox.Click();
            GpuTypeSelectIcon.Click();
            ChooseOption(GpuTypesSelectOptions, computeEngine.GpuTypeText);

            NumberOfGpusSelectIcon.Click();
            ChooseOption(NumberOfGpusOptions, computeEngine.NumberOfGpus);

            LocalSddSelectIcon.Click();
            ChooseOption(LocalSddOptions, computeEngine.LocalSddText);

            DataCenterLocationSelectIcon.Click();
            ChooseOption(DataCenterLocationOptions, computeEngine.DataCenterLocationText);

            CommittedUsageSelectIcon.Click();
            ChooseOption(CommittedUsageOptions, computeEngine.CommittedUsageText);
        }

        private void ChooseOption(ReadOnlyCollection<IWebElement> options, string text)
        {
            foreach (IWebElement option in options)
            {
                if (option.GetAttribute("value") == text)
                {
                    option.Click();
                    break;
                }
            }
        }
    }
}
