using System;
using System.Collections.Generic;
using System.Text;

namespace QingStor_SDK_NET.Yaml
{
	public partial class BlockScalarModifier
	{
        public int GetIndent()
        {
            if (Indent > '0' && Indent <= '9')
            {
                return Indent - '0';
            }
            else
            {
                return 1;
            }
        }

        public ChompingMethod GetChompingMethod()
        {
            switch (Chomp)
            {
                case '-':
                    return ChompingMethod.Strip;
                case '+':
                    return ChompingMethod.Keep;
                default:
                    return ChompingMethod.Clip;
            }
        }
	}
}
