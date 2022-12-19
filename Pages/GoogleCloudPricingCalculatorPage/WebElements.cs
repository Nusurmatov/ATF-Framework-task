using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace Framework.Pages
{
    public partial class GoogleCloudPricingCalculatorPage : AbstractPage
    {
        public IWebElement InstanceField => base.WaitAndFindElement(InstanceFieldLocator);

        public IWebElement OperatingSystemOrSoftwareSelectIcon => base.WaitAndFindElement(OperatingSystemOrSoftwareSelectIconLocator);

        public ReadOnlyCollection<IWebElement> OperatingSystemOrSoftwareOptions
        {
            get
            {
                base.WaitAndFindElement(OperatingSystemOrSoftwareSelectOptionsLocator);
                return base.Driver.FindElements(OperatingSystemOrSoftwareSelectOptionsLocator);
            }
        }

        public IWebElement ProvisionModelSelectIcon => base.WaitAndFindElement(ProvisionModelSelectIconLocator);

        public ReadOnlyCollection<IWebElement> ProvisionModelOptions
        {
            get
            {
                base.Wait.Until(ExpectedConditions.ElementExists(ProvisionModelSelectOptionsLocator));
                return base.Driver.FindElements(ProvisionModelSelectOptionsLocator);
            }
        }

        public IWebElement MachineTypeSelectIcon => base.WaitAndFindElement(MachineTypeSelectIconLocator);

        public ReadOnlyCollection<IWebElement> MachineTypeOptions
        {
            get
            {
                base.Wait.Until(ExpectedConditions.ElementExists(MachineTypeSelectOptionsLocator));
                return base.Driver.FindElements(MachineTypeSelectOptionsLocator);
            }
        }

        public IWebElement AddGpusCheckBox => base.WaitAndFindElement(AddGpusCheckboxLocator);

        public IWebElement GpuTypeSelectIcon => base.WaitAndFindElement(GpuTypeSelectIconLocator);

        public ReadOnlyCollection<IWebElement> GpuTypesSelectOptions
        {
            get
            {
                base.Wait.Until(ExpectedConditions.ElementExists(GpuTypeSelectOptionsLocator));
                return base.Driver.FindElements(GpuTypeSelectOptionsLocator);
            }
        }

        public IWebElement NumberOfGpusSelectIcon => base.WaitAndFindElement(NumberOfGpusSelectIconLocator);

        public ReadOnlyCollection<IWebElement> NumberOfGpusOptions
        {
            get
            {
                base.Wait.Until(ExpectedConditions.ElementExists(NumberOfSelectOptionsLocator));
                return base.Driver.FindElements(NumberOfSelectOptionsLocator);
            }
        }

        public IWebElement LocalSddSelectIcon => base.WaitAndFindElement(LocalSddSelectIconLocator);

        public ReadOnlyCollection<IWebElement> LocalSddOptions
        {
            get
            {
                base.Wait.Until(ExpectedConditions.ElementExists(LocalSddSelectOptionsLocator));
                return base.Driver.FindElements(LocalSddSelectOptionsLocator);
            }
        }

        public IWebElement DataCenterLocationSelectIcon => base.WaitAndFindElement(DataCenterLocationSelectIconLocator);

        public ReadOnlyCollection<IWebElement> DataCenterLocationOptions
        {
            get
            {
                base.Wait.Until(ExpectedConditions.ElementExists(DataCenterLocationSelectOptionsLocator));
                return base.Driver.FindElements(DataCenterLocationSelectOptionsLocator);
            }
        }

        public IWebElement CommittedUsageSelectIcon => base.WaitAndFindElement(CommittedUsageSelectIconLocator);

        public ReadOnlyCollection<IWebElement> CommittedUsageOptions
        {
            get
            {
                base.Wait.Until(ExpectedConditions.ElementExists(CommittedUsageSelectOptionsLocator));
                return base.Driver.FindElements(CommittedUsageSelectOptionsLocator);
            }
        }

        public IWebElement AddToEstimateButton => base.WaitAndFindElement(AddToEstimateButtonLocator);
                
        public IWebElement EmailEstimateButton => base.WaitAndFindElement(EmailEstimateButtonLocator);

        public IWebElement EmailTextField => base.WaitAndFindElement(EmailTextFieldLocator);

        public IWebElement SendEmailButton => base.WaitAndFindElement(SendEmailButtonLocator);

        public IWebElement TotalEstimatedCost => base.WaitAndFindElement(TotalEstimatedCostLocator);
    }
}
