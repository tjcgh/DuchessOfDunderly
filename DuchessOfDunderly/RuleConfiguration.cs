using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using DuchessOfDunderly.DAL.Models;
using Microsoft.Extensions.Configuration;

namespace DuchessOfDunderly
{
    public static class RuleConfiguration
    {
        public static IConfigurationRoot Configuration { get; set; }
        static List<IExceptionRule> rules = new List<IExceptionRule>();

        public static List<IExceptionRule> BuildRuleList()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            IEnumerable<IConfigurationSection> loanRules = Configuration.GetSection("exceptionRules").GetChildren();
            IConfigurationSection libraryPath = Configuration.GetSection("assemblyPath");
            string basePath = string.Format("{0}{1}",Directory.GetCurrentDirectory(),libraryPath.Value);
            foreach (var item in loanRules)
            {
                Assembly discountAssembly = Assembly.LoadFile(string.Format("{0}{1}.dll", basePath, item.Value));
                var discountCalculator = Activator.CreateInstance(discountAssembly.GetType(string.Format("{0}.Discount", item.Value)));

                Assembly ruleAssembly = Assembly.LoadFile(string.Format("{0}{1}.dll", basePath, item.Key));
                rules.Add((IExceptionRule)Activator.CreateInstance(ruleAssembly.GetType(string.Format("{0}.LoanRule", item.Key)), discountCalculator));
            }
            return rules;
        }
    }
}
