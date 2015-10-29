﻿namespace LearningBasic.Test
{
    using System.IO;
    using LearningBasic.Parsing;
    using LearningBasic.Test.Mocks;

    public abstract class BaseTests
    {
        protected static TextReader MakeReader(string inputString)
        {
            return new StringReader(inputString);
        }

        protected static IScanner<Token> MakeScanner(string inputString)
        {
            var reader = MakeReader(inputString);

            return new BasicScanner(reader);
        }

        protected static IParser<Tag> MakeParser()
        {
            return new BasicParser(new BasicScannerFactory());
        }

        protected static MockInputOutput MakeInputOutput(string inputString)
        {
            return new MockInputOutput(inputString);
        }
    }
}
