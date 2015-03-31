using il.examples.nancyfx.Properties;
using Nancy.ViewEngines.SuperSimpleViewEngine;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace il.examples.nancyfx.Common
{
    public class TranslateTokenViewEngineMatcher : ISuperSimpleViewEngineMatcher
    {
        private static readonly Regex TranslationSubstitutionsRegEx =
                new Regex(
                    @"@Translate\.(?<TranslationKey>[a-zA-Z0-9-_]+);?",
                    RegexOptions.Compiled);

        public string Invoke(string content, dynamic model, IViewEngineHost host)
        {
            return TranslationSubstitutionsRegEx.Replace(
                content,
                m =>
                {
                    var translationKey = m.Groups["TranslationKey"].Value;

                    ResourceManager rm = new ResourceManager(typeof(Translations));
                    return rm.GetString(translationKey, CultureInfo.CurrentCulture);
                });
        }
    }
}
