﻿using Message.ORiN3.Provider.V1.Branch.Switcher;
using Message.ORiN3.Provider.V1.Branch.ValueBranch;
using Message.ORiN3.Provider.V1.Factory;
using System;
using Xunit;

namespace Message.ORiN3.Provider.Test.TestByDeveloper
{
    public class CSharpValueToORiN3ValueBranchVerValueBranchTest
    {
        public static TheoryData<object> TestData() => new()
        {
            { true },
            { (bool[])[true, false] },
            { (bool?[])[true, null] },
            { (sbyte)1 },
            { (sbyte[])[1, 2] },
            { (sbyte?[])[1, null] },
            { (short)1 },
            { (short[])[1, 2] },
            { (short?[])[1, null] },
            { 1 },
            { (int[])[1, 2] },
            { (int?[])[1, null] },
            { (long)1 },
            { (long[])[1, 2] },
            { (long?[])[1, null] },
            { (byte)1 },
            { (byte[])[1, 2] },
            { (byte?[])[1, null] },
            { (ushort)1 },
            { (ushort[])[1, 2] },
            { (ushort?[])[1, null] },
            { (uint)1 },
            { (uint[])[1, 2] },
            { (uint?[])[1, null] },
            { (ulong)1 },
            { (ulong[])[1, 2] },
            { (ulong?[])[1, null] },
            { (float)1 },
            { (float[])[1, 2] },
            { (float?[])[1, null] },
            { (double)1 },
            { (double[])[1, 2] },
            { (double?[])[1, null] },
            { "aaa" },
            { (string[])["aaa", "bbb"] },
            { DateTime.Now },
            { (DateTime[])[DateTime.Now, DateTime.Now] },
            { (DateTime?[])[DateTime.Now, null] },
            { (object[])[1, "aaa"] },
            { null },
        };

        [Theory]
        [Trait(nameof(CSharpValueToORiN3ValueBranchVerValueBranch), "CaseOf")]
        [MemberData(nameof(TestData))]
        public void Test01(object value)
        {
            var branch = new CSharpValueToORiN3ValueBranchVerValueBranch
            {
                Source = value
            };
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
