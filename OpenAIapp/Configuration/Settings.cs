using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAIapp.Configuration
{
    public class ConstantSettings : ISettings
    {
        
        public string AzureOpenAiEndPoint { get => ""; }
        public string AzureOpenAiKey { get => ""; }
    }
}
