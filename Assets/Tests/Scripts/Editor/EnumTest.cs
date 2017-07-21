using NUnit.Framework;

namespace Tests {

    public class EnumTest {

        private enum SampleEnum {
            Default,
            Succeed,
            Failure,
        }

        [Test]
        public void TryParseTest() {
            SampleEnum sampleEnumSucceed;
            Assert.IsTrue(ForwardCompatibility.Enum.TryParse("Succeed", out sampleEnumSucceed), "パース成功");
            Assert.AreEqual(SampleEnum.Succeed, sampleEnumSucceed, "パース結果チェック: 成功");

            SampleEnum sampleEnumFailure;
            Assert.IsFalse(ForwardCompatibility.Enum.TryParse("Failed", out sampleEnumFailure), "パース失敗");
            Assert.AreNotEqual(SampleEnum.Failure, sampleEnumFailure, "パース結果チェック: 失敗: Failure と不一致");
            Assert.AreEqual(SampleEnum.Default, sampleEnumFailure, "パース結果チェック: 失敗: Default と一致");
        }

    }

}
