using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReplaceSettings
    {
        public List<string> Files { get; set; } = new();
        public List<Replacement> Replacements { get; set; } = new();
        public string OutputSuffix { get; set; } = ".out";
        public string Encoding { get; set; } = "utf-8";
    }

    public class Replacement
    {
        public string OldValue { get; set; } = "";
        public string NewValue { get; set; } = "";
    }
}
