using System;
using System.Collections.Generic;
using System.Text;

namespace Structs_e_Nullable {
    public struct Ponto {
        public double PX;
        public double PY;

        public override string ToString() {
            return $"({PX},{PY})";
        }
    }
}
