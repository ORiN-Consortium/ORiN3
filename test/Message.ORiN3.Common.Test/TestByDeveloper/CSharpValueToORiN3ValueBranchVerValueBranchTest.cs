using Message.ORiN3.Common.V1.Branch.Switcher;
using Message.ORiN3.Common.V1.Branch.ValueBranch;
using Message.ORiN3.Common.V1.Factory;
using System;
using System.Collections.Generic;
using Xunit;

namespace Message.ORiN3.Common.Test.TestByDeveloper
{
    public class CSharpValueToORiN3ValueBranchVerValueBranchTest
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { (bool)true, };
            yield return new object[] { (bool[])[true, false], };
            yield return new object[] { (bool?[])[true, null], };
            yield return new object[] { (sbyte)1, };
            yield return new object[] { (sbyte[])[1, 2], };
            yield return new object[] { (sbyte?[])[1, null], };
            yield return new object[] { (short)1, };
            yield return new object[] { (short[])[1, 2], };
            yield return new object[] { (short?[])[1, null], };
            yield return new object[] { (int)1, };
            yield return new object[] { (int[])[1, 2], };
            yield return new object[] { (int?[])[1, null], };
            yield return new object[] { (long)1, };
            yield return new object[] { (long[])[1, 2], };
            yield return new object[] { (long?[])[1, null], };
            yield return new object[] { (byte)1, };
            yield return new object[] { (byte[])[1, 2], };
            yield return new object[] { (byte?[])[1, null], };
            yield return new object[] { (ushort)1, };
            yield return new object[] { (ushort[])[1, 2], };
            yield return new object[] { (ushort?[])[1, null], };
            yield return new object[] { (uint)1, };
            yield return new object[] { (uint[])[1, 2], };
            yield return new object[] { (uint?[])[1, null], };
            yield return new object[] { (ulong)1, };
            yield return new object[] { (ulong[])[1, 2], };
            yield return new object[] { (ulong?[])[1, null], };
            yield return new object[] { (float)1, };
            yield return new object[] { (float[])[1, 2], };
            yield return new object[] { (float?[])[1, null], };
            yield return new object[] { (double)1, };
            yield return new object[] { (double[])[1, 2], };
            yield return new object[] { (double?[])[1, null], };
            yield return new object[] { (string)"aaa", };
            yield return new object[] { (string[])["aaa", "bbb"], };
            yield return new object[] { (DateTime)DateTime.Now, };
            yield return new object[] { (DateTime[])[DateTime.Now, DateTime.Now], };
            yield return new object[] { (DateTime?[])[DateTime.Now, null], };
            yield return new object[] { (object[])[1, "aaa"], };
            yield return new object[] { null, };
        }


        [Theory]
        [Trait(nameof(CSharpValueToORiN3ValueBranchVerValueBranch), "CaseOf")]
        [MemberData(nameof(TestData))]
        public void Test01(object value)
        {
            var branch = new CSharpValueToORiN3ValueBranchVerValueBranch();
            branch.Source = value;
            ValueSwitcher.Execute(value, branch);
            if (value is null)
            {
                Assert.True(branch.Result.NullableBool.IsNull);
            }
            else
            {
                var orin3Value = ORiN3ValueFactory.Create((dynamic)value);
                Assert.Equal(orin3Value, branch.Result);
            }
        }
    }
}
