using OpenQA.Selenium;

namespace Framework.Pages
{
    public partial class GoogleCloudPricingCalculatorPage : AbstractPage
    {
        private readonly By InstanceFieldLocator = By.Id("input_90");

        private readonly By OperatingSystemOrSoftwareSelectIconLocator = By.XPath("//*[@id='select_value_label_82']/descendant::span[@class='md-select-icon']");

        private readonly By OperatingSystemOrSoftwareSelectOptionsLocator = By.XPath("//*[@id='select_container_104']/descendant::md-option");

        private readonly By ProvisionModelSelectIconLocator = By.XPath("//*[@id='select_value_label_83']/descendant::span[@class='md-select-icon']");

        private readonly By ProvisionModelSelectOptionsLocator = By.XPath("//*[@id='select_container_108']/descendant::md-option");

        private readonly By MachineTypeSelectIconLocator = By.XPath("//*[@id='select_value_label_86']/descendant::span[@class='md-select-icon']");

        private readonly By MachineTypeSelectOptionsLocator = By.XPath("//*[@id='select_container_118']/descendant::md-option");

        private readonly By AddGpusCheckboxLocator = By.XPath("//*[@aria-label='Add GPUs' and @aria-disabled='false']");

        private readonly By GpuTypeSelectIconLocator = By.XPath("//*[@aria-label='GPU type']");

        private readonly By GpuTypeSelectOptionsLocator = By.XPath("//*[@id='select_container_423']/descendant::md-option");

        private readonly By NumberOfGpusSelectIconLocator = By.XPath("//*[@id='select_424']/descendant::span[@class='md-select-icon']");

        private readonly By NumberOfSelectOptionsLocator = By.XPath("//*[@id='select_container_425']/descendant::md-option");

        private readonly By LocalSddSelectIconLocator = By.XPath("//*[@id='select_value_label_133']/descendant::span[@class='md-select-icon']");

        private readonly By LocalSddSelectOptionsLocator = By.XPath("//*[@id='select_container_151']/descendant::md-option");

        private readonly By DataCenterLocationSelectIconLocator = By.XPath("//*[@id='select_value_label_134']/descendant::span[@class='md-select-icon']");

        private readonly By DataCenterLocationSelectOptionsLocator = By.XPath("//*[@id='select_container_154']/descendant::md-option");

        private readonly By CommittedUsageSelectIconLocator = By.XPath("//*[@id='select_value_label_135']/descendant::span[@class='md-select-icon']");

        private readonly By CommittedUsageSelectOptionsLocator = By.XPath("//*[@id='select_container_159']/descendant::md-option");

        private readonly By AddToEstimateButtonLocator = By.XPath("//*[@aria-label='Add to Estimate' and not(contains(@disabled, 'disabled'))]");

        private readonly By EmailEstimateButtonLocator = By.Id("Email Estimate");

        private readonly By EmailTextFieldLocator = By.CssSelector("[type=email]");

        private readonly By SendEmailButtonLocator = By.XPath("//*[@aria-label='Send Email']");

        private readonly By TotalEstimatedCostLocator = By.XPath("//b[contains(text(), 'Total Estimated Cost:')]");
    }
}
