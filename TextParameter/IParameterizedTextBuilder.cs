using System;
using System.Collections.Generic;
using System.Text;

namespace TextParameter {
    public interface IParameterizedTextBuilder {
        IParameterizedText Parse(string parameterizedText);
    }
}