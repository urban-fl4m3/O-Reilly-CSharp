using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;


namespace Chapter8_Program3
{
    enum SortCriteria
    {
        SizeThenKind,
        KindThenSize
    }

    class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;

        public int Compare([AllowNull] Duck x, [AllowNull] Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)
            {
                if (x.Size < y.Size)
                {
                    return -1;
                }
                else if (x.Size > y.Size)
                {
                    return 1;
                }
                else
                {
                    if (x.Kind < y.Kind)
                    {
                        return -1;
                    }

                    if (x.Kind > y.Kind)
                    {
                        return 1;
                    }

                    return 0;
                }
            }
            else
            {
                if (x.Kind < y.Kind)
                {
                    return -1;
                }
                else if (x.Kind > y.Kind)
                {
                    return 1;
                }
                else
                {
                    if (x.Size < y.Size)
                    {
                        return -1;
                    }
                    else if (x.Size > y.Size)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
