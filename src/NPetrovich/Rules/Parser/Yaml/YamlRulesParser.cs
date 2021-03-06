﻿using System.IO;
using YamlDotNet.RepresentationModel.Serialization;

namespace NPetrovich.Rules.Parser.Yaml
{
    public class YamlRulesParser : IRulesParser
    {
        public Data.Rules Parse(StreamReader data)
        {
            return new Deserializer().Deserialize<Data.Rules>(data);
        }
    }
}
