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
        public void BP_is_Low()
        {
            _bp.Systolic= 120;
            _bp.Diastolic= 50;
            var actual = _bp.Category;
            var expected = BPCategory.Low;
            
            Assert.AreEqual(expected, actual );
        }

        [Test]
        public void BP_is_Normal()
        {
            _bp.Systolic= 120;
            _bp.Diastolic= 70;
            var actual = _bp.Category;
            var expected = BPCategory.Normal;
            
            Assert.AreEqual(expected, actual );
        }
        [Test]
        public void BP_is_Pre_High()
        {
            _bp.Systolic= 130;
            _bp.Diastolic= 70;
            var actual = _bp.Category;
            var expected = BPCategory.PreHigh;
            
            Assert.AreEqual(expected, actual );
        }

        [Test]
        public void BP_is_High()
        {
            _bp.Systolic= 170;
            _bp.Diastolic= 92;
            var actual = _bp.Category;
            var expected = BPCategory.High;
            
            Assert.AreEqual(expected, actual );
        }
    }
}