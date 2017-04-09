using System;
using System.Linq;
using System.Runtime.Loader;
using System.Reflection;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;


namespace TestAdapter
{
    [FileExtension(".dll")]
    [ExtensionUri("executor://testadapter")]
    [DefaultExecutorUri("executor://testadapter")]
    public sealed class TestAdapter : ITestDiscoverer, ITestExecutor
    {
        public void DiscoverTests(
            IEnumerable<string> sources,
            IDiscoveryContext discoveryContext,
            IMessageLogger logger,
            ITestCaseDiscoverySink discoverySink)
        {
        }

        public void RunTests(
            IEnumerable<string> sources,
            IRunContext runContext,
            IFrameworkHandle frameworkHandle)
        {
            foreach (var source in sources)
            {
                var ps = Assembly.Load(AssemblyLoadContext.GetAssemblyName(source)).ExportedTypes
                    .SelectMany(type => type.GetTypeInfo().DeclaredProperties.Where(p => p.GetMethod.IsStatic));

                Console.WriteLine("\n");

                foreach (var p in ps)
                {
                    object v = p.GetValue(null, null) ?? "null";
                    Console.WriteLine($"{p.Name}, {v}");
                }

                Console.WriteLine("\n");
            }
        }

        public void RunTests(
            IEnumerable<TestCase> tests,
            IRunContext runContext,
            IFrameworkHandle frameworkHandle)
        {
        }

        public void Cancel()
        {
        }
    }
}