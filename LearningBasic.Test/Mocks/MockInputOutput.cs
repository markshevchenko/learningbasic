﻿namespace LearningBasic.Test.Mocks
{
    public class MockInputOutput : IInputOutput
    {
        private readonly string inputString;

        public string LastWritten { get; private set; }

        public MockInputOutput()
        {
            inputString = null;
        }

        public MockInputOutput(string inputString)
        {
            this.inputString = inputString;
        }

        public string ReadLine()
        {
            return inputString;
        }

        public void Write(string s)
        {
            LastWritten = s;
        }

        public void Write(string format, params object[] args)
        {
            LastWritten = string.Format(format, args);
        }

        public void WriteLine()
        {
            LastWritten = "\n";
        }

        public void WriteLine(string s)
        {
            LastWritten = s + "\n";
        }

        public void WriteLine(string format, params object[] args)
        {
            LastWritten = string.Format(format, args) + "\n";
        }
    }
}
