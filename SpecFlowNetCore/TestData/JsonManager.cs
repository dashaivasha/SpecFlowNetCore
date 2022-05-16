using SpecFlowNetCore.Constants;

namespace SpecFlowNetCore.TestData
{
    public class JsonManager
    {
        public static TestDetails GetTestData()
        {
            var data = DataSerializer.JsonDeserialize(typeof(TestDetails), Globals.DataPath) as TestDetails;

            return data;
        }
    }
}
