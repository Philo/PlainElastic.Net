﻿using Machine.Specifications;
using PlainElastic.Net.IndexSettings;
using PlainElastic.Net.Utils;

namespace PlainElastic.Net.Tests.Builders.IndexSettings
{
    [Subject(typeof(StandardTokenizer))]
    class When_empty_StandardTokenizer_built
    {
        Because of = () => result = new StandardTokenizer()
                                            .Name("name")
                                            .ToString();

        It should_return_correct_result = () => result.ShouldEqual("'name': { 'type': 'standard' }".AltQuote());

        private static string result;
    }
}