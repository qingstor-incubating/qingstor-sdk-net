using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Scripting.Hosting;
using IronRuby;

namespace QingStor_SDK_CSharp.Yaml
{
    // Yaml Parser
    public class CYamlParse
    {
        private ScriptRuntime irb;
        private ICollection<string> searchPath = new List<string>();
        private dynamic yyaml;

        public CYamlParse()
        {
            irb = Ruby.CreateRuntime();
            searchPath.Add(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            searchPath.Add(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"YLab.YAML"));
            irb.GetRubyEngine().SetSearchPaths(searchPath);

            dynamic rbCfg = irb.UseFile("config.rb");
            var cfgSearchPath = rbCfg.SearchPath();
            foreach (var path in cfgSearchPath)
            {
                searchPath.Add(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (string)path));
            }
            irb.GetRubyEngine().SetSearchPaths(searchPath);

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            string code;
            using (var stream = assembly.GetManifestResourceStream(assembly.GetName().Name + "." + "Yaml.YLabYAML.rb"))
            {
                using (TextReader rbReader = new StreamReader(stream)) 
                {
                    code = rbReader.ReadToEnd();
                }
            }
            irb.GetRubyEngine().Execute(code);

            dynamic ruby = irb.Globals;
            yyaml = ruby.YYAML.@new();
        }

        public dynamic LoadFile(string YamlFile)
        {
            return yyaml.load(YamlFile);
        }

        public dynamic ParseFile(string YamlFile)
        {
            return yyaml.parse(YamlFile);
        }
    }
}
