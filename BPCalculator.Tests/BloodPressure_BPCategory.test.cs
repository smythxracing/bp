using System;
using NUnit.Framework;
using BPCalculator;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly BloodPressure _bp;

        public Tests()
        {
            _bp = new BloodPressure() { Systolic = 100, Diastolic = 60 };
        }

        [Test]
        public void Systolic_Low_BP_is_Low()
        {
            _bp.Systolic = 80;
            _bp.Diastolic = 80;
            var actual = _bp.Category;
            var expected = BPCategory.Low;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Diastolic_Low_BP_is_Low()
        {
            _bp.Systolic = 120;
            _bp.Diastolic = 50;
            var actual = _bp.Category;
            var expected = BPCategory.Low;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void High_Range_BP_is_Normal()
        {
            _bp.Systolic = 120;
            _bp.Diastolic = 80;
            var actual = _bp.Category;
            var expected = BPCategory.Normal;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Low_Range_BP_is_Normal()
        {
            _bp.Systolic = 90;
            _bp.Diastolic = 60;
            var actual = _bp.Category;
            var expected = BPCategory.Normal;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Systolic_Pre_High_BP_is_Pre_High()
        {
            _bp.Systolic = 130;
            _bp.Diastolic = 80;
            var actual = _bp.Category;
            var expected = BPCategory.PreHigh;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Diastolic_Pre_High_BP_is_Pre_High()
        {
            _bp.Systolic = 120;
            _bp.Diastolic = 85;
            var actual = _bp.Category;
            var expected = BPCategory.PreHigh;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Systolic_High_BP_is_High()
        {
            _bp.Systolic = 170;
            _bp.Diastolic = 75;
            var actual = _bp.Category;
            var expected = BPCategory.High;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BP_is_High()
        {
            _bp.Systolic = 120;
            _bp.Diastolic = 92;
            var actual = _bp.Category;
            var expected = BPCategory.High;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Ignore("Work in Progress")]
        public void BP_Out_Of_Range()
        {
            _bp.Systolic = 300;
            _bp.Diastolic = 92;
            var actual = _bp.Category;
            var expected = BPCategory.High;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BP_Suggested_Treatment_Low()
        {
            _bp.Systolic = 120;
            _bp.Diastolic = 50;
            var actual = _bp.SuggestedTreatment;
            var expected = BPSuggestedTreatment.Low;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BP_Suggested_Treatment_Normal()
        {
            _bp.Systolic = 120;
            _bp.Diastolic = 80;
            var actual = _bp.SuggestedTreatment;
            var expected = BPSuggestedTreatment.Normal;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BP_Suggested_Treatment_Pre_High()
        {
            _bp.Systolic = 130;
            _bp.Diastolic = 80;
            var actual = _bp.SuggestedTreatment;
            var expected = BPSuggestedTreatment.PreHigh;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BP_Suggested_Treatment_High()
        {
            _bp.Systolic = 170;
            _bp.Diastolic = 75;
            var actual = _bp.SuggestedTreatment;
            var expected = BPSuggestedTreatment.High;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Ignore("Work in Progress")]
        public void BP_Suggested_Treatment_Out_Of_Range()
        {

            // _bp.Systolic = 2;
            // _bp.Diastolic = 2;
            Assert.Throws<Exception>(
                delegate { _bp.Systolic = 2; _bp.Diastolic = 2; }
                );

        }

    }
}