using Xunit;

namespace ORiN3.Provider.Config.Test.TestByDeveloper;

public class ClassTypeTest
{
    public class GetClassType : TheoryData<string>
    {
        public GetClassType()
        {
            Add(ClassType.ORiN3Controller);
            Add(ClassType.ORiN3Module);
            Add(ClassType.ORiN3Event);
            Add(ClassType.ORiN3Stream);
            Add(ClassType.ORiN3Job);
            Add(ClassType.ORiN3File);
            Add(ClassType.ORiN3BoolVariable);
            Add(ClassType.ORiN3NullableBoolVariable);
            Add(ClassType.ORiN3BoolArrayVariable);
            Add(ClassType.ORiN3NullableBoolArrayVariable);
            Add(ClassType.ORiN3Int8Variable);
            Add(ClassType.ORiN3NullableInt8Variable);
            Add(ClassType.ORiN3Int8ArrayVariable);
            Add(ClassType.ORiN3NullableInt8ArrayVariable);
            Add(ClassType.ORiN3UInt8Variable);
            Add(ClassType.ORiN3NullableUInt8Variable);
            Add(ClassType.ORiN3UInt8ArrayVariable);
            Add(ClassType.ORiN3NullableUInt8ArrayVariable);
            Add(ClassType.ORiN3Int16Variable);
            Add(ClassType.ORiN3NullableInt16Variable);
            Add(ClassType.ORiN3Int16ArrayVariable);
            Add(ClassType.ORiN3NullableInt16ArrayVariable);
            Add(ClassType.ORiN3UInt16Variable);
            Add(ClassType.ORiN3NullableUInt16Variable);
            Add(ClassType.ORiN3UInt16ArrayVariable);
            Add(ClassType.ORiN3NullableUInt16ArrayVariable);
            Add(ClassType.ORiN3Int32Variable);
            Add(ClassType.ORiN3NullableInt32Variable);
            Add(ClassType.ORiN3Int32ArrayVariable);
            Add(ClassType.ORiN3NullableInt32ArrayVariable);
            Add(ClassType.ORiN3UInt32Variable);
            Add(ClassType.ORiN3NullableUInt32Variable);
            Add(ClassType.ORiN3UInt32ArrayVariable);
            Add(ClassType.ORiN3NullableUInt32ArrayVariable);
            Add(ClassType.ORiN3Int64Variable);
            Add(ClassType.ORiN3NullableInt64Variable);
            Add(ClassType.ORiN3Int64ArrayVariable);
            Add(ClassType.ORiN3NullableInt64ArrayVariable);
            Add(ClassType.ORiN3UInt64Variable);
            Add(ClassType.ORiN3NullableUInt64Variable);
            Add(ClassType.ORiN3UInt64ArrayVariable);
            Add(ClassType.ORiN3NullableUInt64ArrayVariable);
            Add(ClassType.ORiN3FloatVariable);
            Add(ClassType.ORiN3NullableFloatVariable);
            Add(ClassType.ORiN3FloatArrayVariable);
            Add(ClassType.ORiN3NullableFloatArrayVariable);
            Add(ClassType.ORiN3DoubleVariable);
            Add(ClassType.ORiN3NullableDoubleVariable);
            Add(ClassType.ORiN3DoubleArrayVariable);
            Add(ClassType.ORiN3NullableDoubleArrayVariable);
            Add(ClassType.ORiN3DateTimeVariable);
            Add(ClassType.ORiN3NullableDateTimeVariable);
            Add(ClassType.ORiN3DateTimeArrayVariable);
            Add(ClassType.ORiN3NullableDateTimeArrayVariable);
            Add(ClassType.ORiN3StringVariable);
            Add(ClassType.ORiN3StringArrayVariable);
            Add(ClassType.ORiN3ObjectVariable);
        }
    }

    [Theory(DisplayName = "Check that each ClassType field is not null or empty")]
    [Trait("Category", nameof(ClassTypeTest))]
    [ClassData(typeof(GetClassType))]
    public void ClassTypeTest01(string classtype)
    {
        Assert.NotNull(classtype);
        Assert.NotEmpty(classtype);
    }
}
