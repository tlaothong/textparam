using System;
using System.Collections.Generic;
using System.Text;

namespace TextParameter {
    public interface IParameterizedText {
        bool IsMatched(string text);
        void ExtractParameters(string text, IDictionary<string, string> parameters);
    }
}